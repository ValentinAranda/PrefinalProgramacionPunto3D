namespace PrefinalProgramacionPunto3D.Windows
{
    partial class frmPunto3DAe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            txtZ = new TextBox();
            label3 = new Label();
            txtY = new TextBox();
            label2 = new Label();
            txtX = new TextBox();
            label1 = new Label();
            label4 = new Label();
            txtColor = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            btnCancelar = new Button();
            btnOK = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtZ);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtY);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtX);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(27, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(197, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = " Punto 3D ";
            // 
            // txtZ
            // 
            txtZ.Location = new Point(54, 83);
            txtZ.Name = "txtZ";
            txtZ.Size = new Size(100, 23);
            txtZ.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 86);
            label3.Name = "label3";
            label3.Size = new Size(17, 15);
            label3.TabIndex = 0;
            label3.Text = "Z:";
            // 
            // txtY
            // 
            txtY.Location = new Point(54, 54);
            txtY.Name = "txtY";
            txtY.Size = new Size(100, 23);
            txtY.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 57);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 0;
            label2.Text = "Y:";
            // 
            // txtX
            // 
            txtX.Location = new Point(54, 25);
            txtX.Name = "txtX";
            txtX.Size = new Size(100, 23);
            txtX.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 28);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "X:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 164);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 1;
            label4.Text = "Color:";
            // 
            // txtColor
            // 
            txtColor.Location = new Point(91, 163);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(133, 23);
            txtColor.TabIndex = 2;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources.cancel_16px;
            btnCancelar.Location = new Point(153, 198);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 54);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnOK
            // 
            btnOK.Image = Properties.Resources.ok_16px;
            btnOK.Location = new Point(30, 198);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 54);
            btnOK.TabIndex = 7;
            btnOK.Text = "OK";
            btnOK.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // frmPunto3DAe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(258, 264);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(txtColor);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            MaximumSize = new Size(274, 303);
            MinimumSize = new Size(274, 303);
            Name = "frmPunto3DAe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPunto3DAe";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtZ;
        private Label label3;
        private TextBox txtY;
        private Label label2;
        private TextBox txtX;
        private Label label1;
        private Label label4;
        private TextBox txtColor;
        private ErrorProvider errorProvider1;
        private Button btnCancelar;
        private Button btnOK;
    }
}