using HtmlAgilityPack;
using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TechMo.GUI.Forms
{
    public partial class frmTestWeb : Form
    {
        String html = "";
        readonly HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
        HtmlNodeCollection allNodes;


        public frmTestWeb()
        {
            InitializeComponent();
       
        }


        private Uri GetValidUri(string url)
        {
            if (!url.StartsWith("http://", StringComparison.OrdinalIgnoreCase) &&
                !url.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
            {
                url = "http://" + url;
            }

            return new Uri(url);
        }

        private void addressBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Prevent the "ding" sound


                try
                {
                    if (Uri.IsWellFormedUriString(this.txtURL.Text, UriKind.Absolute))
                        this.webView.Source = GetValidUri(this.txtURL.Text);
                    else this.webView.Source = new Uri($"https://www.google.com/search?q={this.txtURL.Text}");

                }
                catch
                {
                    this.webView.Source = new Uri($"https://www.google.com");
                }

            }
        }



        private void webView_SourceChanged(object sender, Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs e)
        {
            this.txtURL.Text = this.webView.Source.ToString();
        }

        private async Task<string> GetPageHtmlAsync()
        {
            // Thực thi mã JavaScript để lấy nội dung HTML
            string script = "document.documentElement.outerHTML;";
            var result = await webView.CoreWebView2.ExecuteScriptAsync(script);
            return result;
        }



        private void GetHtml()
        {
            this.labelState.Text = "Getting";
            GetPageHtmlAsync().ContinueWith(task =>
            {

                html = task.Result;
                html = html.Substring(1, html.Length - 2);

                string decodedHtml = HttpUtility.HtmlDecode(html); // Decode HTML entities

                // Remove unwanted Unicode characters
                string cleanHtml = RemoveUnicodeCharacters(decodedHtml);
                // UI updates must be done on the UI thread.
                this.Invoke((MethodInvoker)delegate
                {
                    //SaveHtmlToFile(cleanHtml);
                    this.labelState.Text = "Success";
                    html = cleanHtml;
                    doc.LoadHtml(html);
                });
            });
        }



        private string RemoveUnicodeCharacters(string html)
        {
            // Regex to remove \uXXXX sequences
            string cleanHtml = Regex.Replace(html, @"\\u[\dA-Fa-f]{4}", match =>
            {
                return char.ConvertFromUtf32(int.Parse(match.Value.Substring(2), System.Globalization.NumberStyles.HexNumber));
            });

            return cleanHtml;
        }



        private void SaveHtmlToFile(string htmlContent)
        {
            // Specify a file path
            string filePath = "output.html";

            // Write HTML content to the file
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(htmlContent);
            }

            MessageBox.Show($"HTML content saved to {filePath}", "File Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        string GetXPath(HtmlNode node)
        {
            if (node == null)
                return string.Empty;

            if (node.NodeType == HtmlNodeType.Document)
                return "/";

            if (node.ParentNode == null)
                return node.Name;

            int index = 1;
            foreach (var sibling in node.ParentNode.ChildNodes)
            {
                if (sibling == node)
                    break;

                if (sibling.Name == node.Name)
                    index++;
            }

            return GetXPath(node.ParentNode) + "/" + node.Name + "[" + index + "]";
        }

        private async void AddHoverEffectCss()
        {
            string css = @"
                <style>
                    .hover-effect:hover {
                        outline: 2px solid blue !important;
                    }
                </style>";

            await webView.ExecuteScriptAsync($@"
                var style = document.createElement('style');
                style.innerHTML = `{css}`;
                document.head.appendChild(style);
            ");
        }
        private async void ApplyHoverEffect(string xpath)
        {
            // JavaScript để tìm phần tử bằng XPath, xóa các class hover hiện tại và thêm class hover-effect mới
            string script = $@"
                (function() {{
                    function getElementByXPath(xpath) {{
                        return document.evaluate(xpath, document, null, XPathResult.FIRST_ORDERED_NODE_TYPE, null).singleNodeValue;
                    }}
                    var element = getElementByXPath('{xpath}');
                    if (element) {{
                        // Xóa các class hover hiện tại
                        element.classList.forEach(cls => {{
                            if (cls.includes('hover')) {{
                                element.classList.remove(cls);
                            }}
                        }});
                        console.log('Removed existing hover classes from element: ', element);

                        // Thêm class hover-effect mới
                        element.classList.add('hover-effect');
                        console.log('Added hover-effect class to element: ', element);

                        // Tạo phần tử hiển thị tên thẻ
                        var tagNameElement = document.createElement('div');
                        tagNameElement.classList.add('tag-name');
                        tagNameElement.innerText = element.tagName;
                        element.appendChild(tagNameElement);

                        return true;
                    }} else {{
                        console.log('Element not found for XPath: {xpath}');
                        return false;
                    }}
                }})();
            ";

            var result = await webView.ExecuteScriptAsync(script);
            Console.WriteLine($"Script executed, result: {result}"); // Ghi log kết quả thực thi script

            // Thêm CSS để thêm hiệu ứng hover với viền màu xanh và hiển thị tên thẻ
            string css = @"
                .hover-effect:hover {
                    outline: 2px solid blue !important;
                    position: relative;
                }
                .tag-name {
                    position: absolute;
                    top: -20px;
                    left: 0;
                    background-color: blue;
                    color: white;
                    padding: 2px 5px;
                    font-size: 12px;
                    z-index: 1000;
                    display: none;
                }
                .hover-effect:hover .tag-name {
                    display: block;
                }
            ";

            var cssResult = await webView.ExecuteScriptAsync($@"
                var style = document.createElement('style');
                style.innerHTML = `{css}`;
                document.head.appendChild(style);
                console.log('CSS injected');
            ");
            Console.WriteLine($"CSS injection result: {cssResult}"); // Ghi log kết quả chèn CSS
        }

        private async void SearchAllNode()
        {
            textBoxResult.Text = "Get Elements" + Environment.NewLine;
            labelState.Text = "Getting..";

            if (textBoxFilterBytagName.Text == "")
                allNodes = doc.DocumentNode.SelectNodes("//*");
            else
                allNodes = doc.DocumentNode.SelectNodes($"//{textBoxFilterBytagName.Text}");

            //Console.WriteLine(allNodes.Count);

            if (allNodes == null)
            {
                textBoxResult.Text = "Null" + Environment.NewLine;
            }
            else
            {
                String infos = "";
                int count = 0;
                foreach (var node in allNodes)
                {
                    if (
                        node.Name != "head" &&
                        node.Name != "html" &&
                        node.Name != "style" &&
                        node.Name != "body" &&
                        node.Name != "meta" &&
                        node.Name != "link" &&
                        node.Name != "script" &&
                        node.Name != "path" &&
                        (node.ChildNodes.Count < 2)


                        )
                    {
                        if (!node.HasChildNodes || node.ChildNodes.All(child => child.NodeType == HtmlNodeType.Text))
                        {
                            if (((node.Name == "image" || node.Name == "img") && node.GetAttributeValue("src", "") != "") || node.InnerText != "")
                            {
                                if (node.InnerText.ToLower().Contains(this.textBoxTextElement.Text.ToLower()))
                                {
                                    count++;
                                    infos += GeInfoNode(node);
                                }

                            }

                        }

                    }
                }
                textBoxResult.Text += $"Count: {count}{Environment.NewLine}{Environment.NewLine}";
                textBoxResult.Text += infos;

            }
            labelState.Text = "Geted";
        }


        private void buttonFindElement_Click(object sender, EventArgs e)
        {
            SearchAllNode();
        }

        private String GeInfoNode(HtmlNode node)
        {
            String result = "";
            string elementName = node.Name;
            string xpath = GetXPath(node);


            result += $"Element: {elementName}{Environment.NewLine}";


            if (node.Name == "img" || node.Name == "image")
                result += $"Scr: {node.GetAttributeValue("src", "")}{Environment.NewLine}";
            result += $"Text: {node.InnerText}{Environment.NewLine}";
            result += $"HasChildNodes: {!node.HasChildNodes || node.ChildNodes.All(child => child.NodeType == HtmlNodeType.Text)}{Environment.NewLine}";
            result += $"Child count: {node.ChildNodes.Count}{Environment.NewLine}";
            result += $"XPath: {xpath}{Environment.NewLine}";
            result += $"{Environment.NewLine}";

            return result;
        }

        private async void WebView2_GetElementAtMousePosition(Point mousePoint)
        {

        }

        private void webView_NavigationStarting(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs e)
        {
            this.labelState.Text = "Loading";
        }

        private void webView_MouseMove(object sender, MouseEventArgs e)
        {
            // Xử lý sự kiện khi di chuyển chuột trên WebView2
            Point mousePoint = e.Location;
            WebView2_GetElementAtMousePosition(mousePoint);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            GetHtml();
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            this.webView.Reload();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.webView.GoBack();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.webView.GoForward();
        }

        private void webView_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            this.labelState.Text = "Loaded";
            checkBoxSelectMode.Checked = false;
        }

        private void buttonFill_Click(object sender, EventArgs e)
        {
            if (textBoxFilterBytagName.Text == "")
                allNodes = doc.DocumentNode.SelectNodes("//*");
            else
                allNodes = doc.DocumentNode.SelectNodes($"//{textBoxFilterBytagName.Text}");
        }

        private String ReadFile(String path)
        {
            try
            {
                // Kiểm tra xem file có tồn tại không
                if (!File.Exists(path)) return "";

                using (StreamReader reader = new StreamReader(path))
                {
                    string content = reader.ReadToEnd(); // Đọc toàn bộ nội dung của file
                    return content;
                }
            }
            catch (Exception)
            {
                return "";
            }
        }



        private void buttonNoClick_Click(object sender, EventArgs e)
        {
            // Cách 1
            // Chèn đoạn mã JavaScript để bắt sự kiện click và ghi log
            //webView.CoreWebView2.ExecuteScriptAsync(@"
            //    // Thêm lớp CSS 'no-click' với thuộc tính 'pointer-events: none'
            //    var style = document.createElement('style');
            //    style.type = 'text/css';
            //    style.innerHTML = '.no-click { pointer-events: none !important; }';
            //    document.head.appendChild(style);

            //    // Thêm lớp 'no-click' vào body để vô hiệu hóa click
            //    document.body.classList.add('no-click');");

            // Cách 2
            // Chèn đoạn mã JavaScript để bắt sự kiện click và ghi log

            string checkJQueryScript = @"
                if (typeof jQuery == 'undefined') {
                    alert('jQuery is not loaded. Loading jQuery...');
                    var script = document.createElement('script');
                    script.src = 'https://code.jquery.com/jquery-3.6.0.min.js';
                    script.type = 'text/javascript';
                    script.onload = function() {
                        alert('jQuery loaded successfully.');
                        $('*').off('click');
                        alert('All click events removed');
                    };
                    document.getElementsByTagName('head')[0].appendChild(script);
                } else {
                    alert('jQuery is already loaded.');
                    $('*').off('click');
                    alert('All click events removed');
                }
            ";

            webView.CoreWebView2.ExecuteScriptAsync("noClickXX();");

        }

        private void buttonUnNoClick_Click(object sender, EventArgs e)
        {
            // Chèn đoạn mã JavaScript để bắt sự kiện click và ghi log
            //webView.CoreWebView2.ExecuteScriptAsync(@"
            //   // Xóa lớp 'no-click' khỏi body để bật lại click
            //    document.body.classList.remove('no-click');");


            // Cách 2

            //webView.CoreWebView2.ExecuteScriptAsync(@"

            //    function enableClick() {
            //document.removeEventListener('click', function(e) {
            //    e.preventDefault();
            //}, true);
            //    ");

            webView.CoreWebView2.ExecuteScriptAsync("unNoClickXX();");
        }

        private void buttonAddStyle_Click(object sender, EventArgs e)
        {
            webView.CoreWebView2.ExecuteScriptAsync(@"
                var unClickStyle = document.createElement('style');
                unClickStyle.type = 'text/css';
                unClickStyle.innerHTML = `
                        .disable-click {
                            pointer-events: none !important;
                        }`;




                var hoverStyle = document.createElement('style');
                hoverStyle.type = 'text/css';
                hoverStyle.innerHTML = `
                        .hover-effect:hover {
                            border: 2px solid blue !important;
                            position: relative;
                        }

                        .tag-name {
                            position: fixed;
                            top: 10px;
                            left: 10px;
                            background-color: rgba(0, 0, 0, 0.7);
                            color: white;
                            padding: 2px 5px;
                            border-radius: 3px;
                            z-index: 1000;
                            font-size: 14px;
                            display: none;
                        }`;

                document.head.appendChild(unClickStyle);
                document.head.appendChild(hoverStyle);


                // Tạo phần tử để hiển thị tên thẻ
                var tagNameElement = document.createElement('div');
                tagNameElement.classList.add('tag-name');
                document.body.appendChild(tagNameElement);

                function addHover(xpath) {
                    var elements = document.evaluate(xpath, document, null, XPathResult.ORDERED_NODE_SNAPSHOT_TYPE, null);
                    for (var i = 0; i < elements.snapshotLength; i++) {
                        var element = elements.snapshotItem(i);
                        element.classList.add('hover-effect');

                        element.onclick = function(event) {
                            // Thực hiện các hành động bạn muốn khi phần tử được click

                          alert('Temporary click event overridden for element:', this);

                            // Gọi lại sự kiện click gốc nếu cần
                            //if (originalClickHandler) {
                            //    originalClickHandler.call(this, event);
                            //}
                        };
        
                        element.addEventListener('mouseover', function(event) {
                            var el = event.target;
                            tagNameElement.textContent = el.tagName.toLowerCase();
                            tagNameElement.style.display = 'block';
                        });
        
                        element.addEventListener('mouseout', function(event) {
                            tagNameElement.style.display = 'none';
                        });
                    }
                }


                ");

            string script = @"
                (function() {
                    // Tạo CSS cho FAB
                    var style = document.createElement('style');
                    style.innerHTML = `
                        .floating-button {
                            position: fixed;
                            bottom: 20px;
                            right: 20px;
                            width: 60px;
                            height: 60px;
                            background-color: #f39c12;
                            border-radius: 50%;
                            box-shadow: 0px 2px 10px rgba(0, 0, 0, 0.3);
                            display: flex;
                            justify-content: center;
                            align-items: center;
                            color: white;
                            font-size: 24px;
                            cursor: pointer;
                            z-index: 1000;
                        }
                    `;
                    document.head.appendChild(style);

                    // Tạo FAB
                    var floatingButton = document.createElement('div');
                    floatingButton.className = 'floating-button';
                    floatingButton.innerText = 'Remove Click';

                    // Thêm sự kiện click vào FAB
                    floatingButton.onclick = function() {
                        document.addEventListener('click', function (event) {
                        event.stopPropagation();
                        event.preventDefault();
                        }, true); //;
                    };

                    // Thêm FAB vào body
                    document.body.appendChild(floatingButton);
                })();


               
            ";

            // Thực thi script để tạo FAB
            webView.CoreWebView2.ExecuteScriptAsync(script);
        }
 

        private void buttonLoadJS_Click(object sender, EventArgs e)
        {
            string jsContent1 = ReadFile($"{Program.getRunningPath()}/Resources/JavaScript/build/selectorgadget_combined.js");  
            string cssContent = ReadFile($"{Program.getRunningPath()}/Resources/JavaScript/build/selectorgadget_combined.css");

            jsContent1 = jsContent1.Replace("\\", "\\\\")
                                    .Replace("`", "\\`")
                                    .Replace("\"", "\\\"");

            string mainScript = ReadFile($"{Program.getRunningPath()}/Resources/JavaScript/selectorgadget.js");
            mainScript = mainScript.Replace("{style}", cssContent);
            mainScript = mainScript.Replace("{script1}", jsContent1);

            webView.CoreWebView2.ExecuteScriptAsync(mainScript);
        }

        private void checkBoxSelectMode_CheckedChanged(object sender, EventArgs e)
        {
            webView.CoreWebView2.ExecuteScriptAsync("SelectorGadget.toggle();");
        }

   
        private void webView_WebMessageReceived(object sender, CoreWebView2WebMessageReceivedEventArgs e)
        {
            try
            {
                textBoxResult.Text += e.TryGetWebMessageAsString() + Environment.NewLine + Environment.NewLine;
            }
           catch { }
        }

        private HttpListener httpListener;
        private string redirectUri = "http://localhost:3000";

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            StartHttpListener();
            string loginUrl = $"http://www.techmo.click:8050";
            Process.Start(new ProcessStartInfo
            {
                FileName = loginUrl,
                UseShellExecute = true
            });
        }

        private void StartHttpListener()
        {
            httpListener = new HttpListener();
            httpListener.Prefixes.Add(redirectUri + "/");
            httpListener.Start();
            httpListener.BeginGetContext(new AsyncCallback(HttpListenerCallback), httpListener);
        }

        private void HttpListenerCallback(IAsyncResult result)
        {
            var context = httpListener.EndGetContext(result);
            var request = context.Request;
            var response = context.Response;
            

            if (request.Url.AbsolutePath == "/callback")
            {
                // Xử lý token hoặc thông tin đăng nhập thành công ở đây
                var queryParams = request.QueryString;
               
                string token = queryParams["token"]; // Lấy token từ URL nếu có
                if (!string.IsNullOrEmpty(token))
                {
                    // Đăng nhập thành công
                    this.Invoke(new Action(() =>
                    {
                        MessageBox.Show($"Đăng nhập thành công! token = {token}");
                    
                    }));
                }

            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (httpListener != null && httpListener.IsListening)
            {
                httpListener.Stop();
                httpListener.Close();
            }
        }
    }

}
