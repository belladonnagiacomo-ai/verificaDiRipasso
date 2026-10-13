namespace verificaDiRipasso
{
    partial class cifra
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
            lista = new ListBox();
            converti = new Button();
            SuspendLayout();
            // 
            // lista
            // 
            lista.FormattingEnabled = true;
            lista.ItemHeight = 15;
            lista.Location = new Point(39, 28);
            lista.Name = "lista";
            lista.Size = new Size(266, 214);
            lista.TabIndex = 0;
            // 
            // converti
            // 
            converti.Location = new Point(311, 28);
            converti.Name = "converti";
            converti.Size = new Size(120, 65);
            converti.TabIndex = 1;
            converti.Text = "Cifra";
            converti.UseVisualStyleBackColor = true;
            converti.Click += converti_Click_1;
            // 
            // cifra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 666);
            Controls.Add(converti);
            Controls.Add(lista);
            Name = "cifra";
            Text = "Cifra";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lista;
        private Button converti;
    }
}
