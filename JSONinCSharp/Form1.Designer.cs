namespace JSONinCSharp
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
            this.txtNomes = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtExibe = new System.Windows.Forms.DataGridView();
            this.txtList = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtExibe)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomes
            // 
            this.txtNomes.Location = new System.Drawing.Point(85, 59);
            this.txtNomes.Name = "txtNomes";
            this.txtNomes.Size = new System.Drawing.Size(466, 27);
            this.txtNomes.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(105, 161);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.txtAdd_Click);
            // 
            // dtExibe
            // 
            this.dtExibe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtExibe.Location = new System.Drawing.Point(75, 231);
            this.dtExibe.Name = "dtExibe";
            this.dtExibe.RowHeadersWidth = 51;
            this.dtExibe.RowTemplate.Height = 29;
            this.dtExibe.Size = new System.Drawing.Size(300, 188);
            this.dtExibe.TabIndex = 2;
            // 
            // txtList
            // 
            this.txtList.Location = new System.Drawing.Point(427, 231);
            this.txtList.Multiline = true;
            this.txtList.Name = "txtList";
            this.txtList.Size = new System.Drawing.Size(280, 188);
            this.txtList.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtList);
            this.Controls.Add(this.dtExibe);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNomes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtExibe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNomes;
        private Button btnAdd;
        private DataGridView dtExibe;
        private TextBox txtList;
    }
}