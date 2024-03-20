namespace BMI
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
            label1 = new Label();
            txtAltezza = new TextBox();
            txtPeso = new TextBox();
            label2 = new Label();
            btnCalcoloBMI = new Button();
            btnReset = new Button();
            txtRisultato = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 36);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Altezza (m)";
            // 
            // txtAltezza
            // 
            txtAltezza.Location = new Point(101, 33);
            txtAltezza.Name = "txtAltezza";
            txtAltezza.Size = new Size(98, 23);
            txtAltezza.TabIndex = 1;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(101, 67);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(98, 23);
            txtPeso.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 70);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Peso (Kg)";
            // 
            // btnCalcoloBMI
            // 
            btnCalcoloBMI.Location = new Point(23, 108);
            btnCalcoloBMI.Name = "btnCalcoloBMI";
            btnCalcoloBMI.Size = new Size(176, 38);
            btnCalcoloBMI.TabIndex = 4;
            btnCalcoloBMI.Text = "Calcolo BMI";
            btnCalcoloBMI.UseVisualStyleBackColor = true;
            btnCalcoloBMI.Click += btnCalcoloBMI_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(23, 230);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(176, 38);
            btnReset.TabIndex = 5;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // txtRisultato
            // 
            txtRisultato.Enabled = false;
            txtRisultato.Location = new Point(23, 176);
            txtRisultato.Name = "txtRisultato";
            txtRisultato.Size = new Size(176, 23);
            txtRisultato.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 158);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 6;
            label3.Text = "BMI";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(230, 280);
            Controls.Add(txtRisultato);
            Controls.Add(label3);
            Controls.Add(btnReset);
            Controls.Add(btnCalcoloBMI);
            Controls.Add(txtPeso);
            Controls.Add(label2);
            Controls.Add(txtAltezza);
            Controls.Add(label1);
            Name = "Form1";
            Text = "BMI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAltezza;
        private TextBox txtPeso;
        private Label label2;
        private Button btnCalcoloBMI;
        private Button btnReset;
        private TextBox txtRisultato;
        private Label label3;
    }
}
