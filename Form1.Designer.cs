namespace GTAGmodPreset
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SelectJson = new Button();
            SelectGame = new Button();
            InstallPreset = new Button();
            JsonPathLabel = new Label();
            GamePathLabel = new Label();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // SelectJson
            // 
            SelectJson.Location = new Point(165, 43);
            SelectJson.Name = "SelectJson";
            SelectJson.Size = new Size(138, 39);
            SelectJson.TabIndex = 0;
            SelectJson.Text = "Select JSON";
            SelectJson.UseVisualStyleBackColor = true;
            SelectJson.Click += SelectJson_Click;
            // 
            // SelectGame
            // 
            SelectGame.Location = new Point(165, 148);
            SelectGame.Name = "SelectGame";
            SelectGame.Size = new Size(138, 39);
            SelectGame.TabIndex = 1;
            SelectGame.Text = "Select game path";
            SelectGame.UseVisualStyleBackColor = true;
            SelectGame.Click += SelectGame_Click;
            // 
            // InstallPreset
            // 
            InstallPreset.Location = new Point(165, 257);
            InstallPreset.Name = "InstallPreset";
            InstallPreset.Size = new Size(138, 39);
            InstallPreset.TabIndex = 2;
            InstallPreset.Text = "Install preset";
            InstallPreset.UseVisualStyleBackColor = true;
            InstallPreset.Click += InstallPreset_Click;
            // 
            // JsonPathLabel
            // 
            JsonPathLabel.AutoSize = true;
            JsonPathLabel.Location = new Point(93, 106);
            JsonPathLabel.Name = "JsonPathLabel";
            JsonPathLabel.Size = new Size(0, 15);
            JsonPathLabel.TabIndex = 3;
            // 
            // GamePathLabel
            // 
            GamePathLabel.AutoSize = true;
            GamePathLabel.Location = new Point(93, 213);
            GamePathLabel.Name = "GamePathLabel";
            GamePathLabel.Size = new Size(0, 15);
            GamePathLabel.TabIndex = 4;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(542, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(301, 424);
            listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 434);
            Controls.Add(listBox1);
            Controls.Add(GamePathLabel);
            Controls.Add(JsonPathLabel);
            Controls.Add(InstallPreset);
            Controls.Add(SelectGame);
            Controls.Add(SelectJson);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SelectJson;
        private Button SelectGame;
        private Button InstallPreset;
        private Label JsonPathLabel;
        private Label GamePathLabel;
        private ListBox listBox1;
    }
}
