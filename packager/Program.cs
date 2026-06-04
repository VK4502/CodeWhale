using System.Reflection;
using Microsoft.Web.WebView2.WinForms;

namespace GamePackager;

static class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        var form = new Form
        {
            Text = "贪吃蛇",
            Width = 500,
            Height = 700,
            StartPosition = FormStartPosition.CenterScreen
        };

        var webView = new WebView2
        {
            Dock = DockStyle.Fill
        };
        form.Controls.Add(webView);

        webView.CoreWebView2InitializationCompleted += (_, _) =>
        {
            string html = LoadEmbeddedHtml();
            webView.CoreWebView2.NavigateToString(html);
        };

        webView.EnsureCoreWebView2Async();
        Application.Run(form);
    }

    static string LoadEmbeddedHtml()
    {
        var asm = Assembly.GetExecutingAssembly();
        string resourceName = asm.GetManifestResourceNames()
            .First(n => n.EndsWith("game.html"));
        using var stream = asm.GetManifestResourceStream(resourceName)!;
        using var reader = new StreamReader(stream);
        return reader.ReadToEnd();
    }
}
