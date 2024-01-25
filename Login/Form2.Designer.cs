namespace Login
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            comPasarela = new ComboBox();
            listProduct = new ListBox();
            imgProduct = new PictureBox();
            btnVolver = new Button();
            imgPasarela = new PictureBox();
            btnPagar = new Button();
            lblResult = new Label();
            ((System.ComponentModel.ISupportInitialize)imgProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgPasarela).BeginInit();
            SuspendLayout();
            // 
            // comPasarela
            // 
            comPasarela.FormattingEnabled = true;
            comPasarela.Items.AddRange(new object[] { "paypal", "tdc" });
            comPasarela.Location = new Point(423, 41);
            comPasarela.Name = "comPasarela";
            comPasarela.Size = new Size(121, 23);
            comPasarela.TabIndex = 1;
            comPasarela.SelectedIndexChanged += comPasarela_SelectedIndexChanged;
            // 
            // listProduct
            // 
            listProduct.FormattingEnabled = true;
            listProduct.ItemHeight = 15;
            listProduct.Items.AddRange(new object[] { "shirt", "short", "shoes" });
            listProduct.Location = new Point(171, 41);
            listProduct.Name = "listProduct";
            listProduct.Size = new Size(120, 94);
            listProduct.TabIndex = 2;
            listProduct.SelectedIndexChanged += listProduct_SelectedIndexChanged;
            // 
            // imgProduct
            // 
            imgProduct.Location = new Point(171, 174);
            imgProduct.Name = "imgProduct";
            imgProduct.Size = new Size(120, 86);
            imgProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            imgProduct.TabIndex = 3;
            imgProduct.TabStop = false;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(171, 301);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(120, 23);
            btnVolver.TabIndex = 4;
            btnVolver.Text = "volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // imgPasarela
            // 
            imgPasarela.Location = new Point(424, 174);
            imgPasarela.Name = "imgPasarela";
            imgPasarela.Size = new Size(120, 86);
            imgPasarela.SizeMode = PictureBoxSizeMode.StretchImage;
            imgPasarela.TabIndex = 3;
            imgPasarela.TabStop = false;
            // 
            // btnPagar
            // 
            btnPagar.Location = new Point(424, 301);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(120, 23);
            btnPagar.TabIndex = 4;
            btnPagar.Text = "pagar";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(171, 372);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(78, 32);
            lblResult.TabIndex = 5;
            lblResult.Text = "label1";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnPagar);
            Controls.Add(btnVolver);
            Controls.Add(imgPasarela);
            Controls.Add(imgProduct);
            Controls.Add(listProduct);
            Controls.Add(comPasarela);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "DashBoard";
            ((System.ComponentModel.ISupportInitialize)imgProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgPasarela).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comPasarela;
        private ListBox listProduct;
        private PictureBox imgProduct;
        private Button btnVolver;
        private PictureBox imgPasarela;
        private Button btnPagar;
        private Label lblResult;
    }
}