using System;
using System.IO;
using BPS.LineCounter;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

class Program: Form
{
    string[] trackedDirs;
    private Button runButton;
    private CheckBox cssCheckbox;
    private CheckBox htmlCheckbox;
    private CheckBox jsCheckbox;
    private CheckBox csCheckbox;
    private CheckBox phpCheckbox;
    private Label MarkupLabel;
    private Panel MarkupPanel;
    private Panel ProgrammingPanel;
    private Label ProgrammingLabel;

    bool useHTML = true;
    bool useCSS = true;
    bool usePHP = true;
    bool useCS = true;
    bool useJS = true;

    Program()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Program));
            runButton = new Button();
            cssCheckbox = new CheckBox();
            htmlCheckbox = new CheckBox();
            jsCheckbox = new CheckBox();
            csCheckbox = new CheckBox();
            phpCheckbox = new CheckBox();
            MarkupLabel = new Label();
            MarkupPanel = new Panel();
            ProgrammingPanel = new Panel();
            ProgrammingLabel = new Label();
            MarkupPanel.SuspendLayout();
            ProgrammingPanel.SuspendLayout();
            SuspendLayout();
            // 
            // runButton
            // 
            runButton.BackColor = Color.LightGray;
            resources.ApplyResources(runButton, "runButton");
            runButton.ForeColor = Color.Black;
            runButton.Name = "runButton";
            runButton.UseVisualStyleBackColor = false;
            runButton.Click += new EventHandler(runApp);
            // 
            // cssCheckbox
            // 
            resources.ApplyResources(cssCheckbox, "cssCheckbox");
            cssCheckbox.BackColor = Color.Transparent;
            cssCheckbox.Checked = true;
            cssCheckbox.CheckState = CheckState.Checked;
            cssCheckbox.ForeColor = Color.Black;
            cssCheckbox.Name = "cssCheckbox";
            cssCheckbox.UseVisualStyleBackColor = false;
            cssCheckbox.CheckedChanged += new EventHandler(useCSS_CheckChanged);
            // 
            // htmlCheckbox
            // 
            resources.ApplyResources(htmlCheckbox, "htmlCheckbox");
            htmlCheckbox.BackColor = Color.Transparent;
            htmlCheckbox.Checked = true;
            htmlCheckbox.CheckState = CheckState.Checked;
            htmlCheckbox.ForeColor = Color.Black;
            htmlCheckbox.Name = "htmlCheckbox";
            htmlCheckbox.UseVisualStyleBackColor = false;
            htmlCheckbox.CheckedChanged += new EventHandler(useHTML_CheckChanged);
            // 
            // jsCheckbox
            // 
            resources.ApplyResources(jsCheckbox, "jsCheckbox");
            jsCheckbox.BackColor = Color.Transparent;
            jsCheckbox.Checked = true;
            jsCheckbox.CheckState = CheckState.Checked;
            jsCheckbox.ForeColor = Color.Black;
            jsCheckbox.Name = "jsCheckbox";
            jsCheckbox.UseVisualStyleBackColor = false;
            jsCheckbox.CheckedChanged += new EventHandler(useJS_CheckChanged);
            // 
            // csCheckbox
            // 
            resources.ApplyResources(csCheckbox, "csCheckbox");
            csCheckbox.BackColor = Color.Transparent;
            csCheckbox.Checked = true;
            csCheckbox.CheckState = CheckState.Checked;
            csCheckbox.ForeColor = Color.Black;
            csCheckbox.Name = "csCheckbox";
            csCheckbox.UseVisualStyleBackColor = false;
            csCheckbox.CheckedChanged += new EventHandler(useCS_CheckChanged);
            // 
            // phpCheckbox
            // 
            resources.ApplyResources(phpCheckbox, "phpCheckbox");
            phpCheckbox.BackColor = Color.Transparent;
            phpCheckbox.Checked = true;
            phpCheckbox.CheckState = CheckState.Checked;
            phpCheckbox.ForeColor = Color.Black;
            phpCheckbox.Name = "phpCheckbox";
            phpCheckbox.UseVisualStyleBackColor = false;
            phpCheckbox.CheckedChanged += new EventHandler(usePHP_CheckChanged);
            // 
            // MarkupLabel
            // 
            resources.ApplyResources(MarkupLabel, "MarkupLabel");
            MarkupLabel.BackColor = Color.LightGray;
            MarkupLabel.FlatStyle = FlatStyle.Flat;
            MarkupLabel.ForeColor = Color.Black;
            MarkupLabel.Name = "MarkupLabel";
            // 
            // MarkupPanel
            // 
            MarkupPanel.BackColor = Color.LightGray;
            MarkupPanel.Controls.Add(MarkupLabel);
            MarkupPanel.Controls.Add(cssCheckbox);
            MarkupPanel.Controls.Add(htmlCheckbox);
            resources.ApplyResources(MarkupPanel, "MarkupPanel");
            MarkupPanel.Name = "MarkupPanel";
            // 
            // ProgrammingPanel
            // 
            ProgrammingPanel.BackColor = Color.LightGray;
            ProgrammingPanel.Controls.Add(ProgrammingLabel);
            ProgrammingPanel.Controls.Add(phpCheckbox);
            ProgrammingPanel.Controls.Add(csCheckbox);
            ProgrammingPanel.Controls.Add(jsCheckbox);
            resources.ApplyResources(ProgrammingPanel, "ProgrammingPanel");
            ProgrammingPanel.Name = "ProgrammingPanel";
            // 
            // ProgrammingLabel
            // 
            resources.ApplyResources(ProgrammingLabel, "ProgrammingLabel");
            ProgrammingLabel.BackColor = Color.LightGray;
            ProgrammingLabel.FlatStyle = FlatStyle.Flat;
            ProgrammingLabel.ForeColor = Color.Black;
            ProgrammingLabel.Name = "ProgrammingLabel";
            // 
            // Program
            // 
            BackColor = Color.DimGray;
            resources.ApplyResources(this, "$this");
            Controls.Add(ProgrammingPanel);
            Controls.Add(runButton);
            Controls.Add(MarkupPanel);
            ForeColor = Color.Silver;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Program";
            MarkupPanel.ResumeLayout(false);
            MarkupPanel.PerformLayout();
            ProgrammingPanel.ResumeLayout(false);
            ProgrammingPanel.PerformLayout();
            ResumeLayout(false);

    }

    static void Main()
    {
        Application.EnableVisualStyles();

        if (!File.Exists("trackedfiles.txt"))
        {
            Console.WriteLine("Creating trackedfiles.txt");
            File.Create("trackedfiles.txt");
        }


        Application.Run(new Program());
    }



    private void useHTML_CheckChanged(object sender, EventArgs e)
    {
        useHTML = htmlCheckbox.Checked;
    }

    private void useCSS_CheckChanged(object sender, EventArgs e)
    {
        useCSS = cssCheckbox.Checked;
    }

    private void usePHP_CheckChanged(object sender, EventArgs e)
    {
        usePHP = phpCheckbox.Checked;
    }

    private void useCS_CheckChanged(object sender, EventArgs e)
    {
        useCS = csCheckbox.Checked;
    }

    private void useJS_CheckChanged(object sender, EventArgs e)
    {
        useJS = jsCheckbox.Checked;
    }

    private void runApp(object sender, EventArgs e)
    {
        trackedDirs = File.ReadAllLines("trackedfiles.txt");
        Counter.CountLines(trackedDirs, useCSS, useHTML, usePHP, useCS, useJS);
    }
}
