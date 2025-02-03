namespace DATABASEFIRSTLIAGE25
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnModifierCategorie = new System.Windows.Forms.Button();
            this.btnSupprimerCategorie = new System.Windows.Forms.Button();
            this.dataGridViewCategorie = new System.Windows.Forms.DataGridView();
            this.btnAddCategorie = new System.Windows.Forms.Button();
            this.txtLibelleCategorie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnModifierProducts = new System.Windows.Forms.Button();
            this.btnSupprimerProducts = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.btnAddProducts = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtLibelleProducts = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategorie)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(44, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1146, 501);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnModifierCategorie);
            this.tabPage1.Controls.Add(this.btnSupprimerCategorie);
            this.tabPage1.Controls.Add(this.dataGridViewCategorie);
            this.tabPage1.Controls.Add(this.btnAddCategorie);
            this.tabPage1.Controls.Add(this.txtLibelleCategorie);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1138, 468);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnModifierCategorie
            // 
            this.btnModifierCategorie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnModifierCategorie.Location = new System.Drawing.Point(358, 407);
            this.btnModifierCategorie.Name = "btnModifierCategorie";
            this.btnModifierCategorie.Size = new System.Drawing.Size(170, 34);
            this.btnModifierCategorie.TabIndex = 5;
            this.btnModifierCategorie.Text = "Modifier";
            this.btnModifierCategorie.UseVisualStyleBackColor = false;
            // 
            // btnSupprimerCategorie
            // 
            this.btnSupprimerCategorie.BackColor = System.Drawing.Color.Red;
            this.btnSupprimerCategorie.Location = new System.Drawing.Point(682, 407);
            this.btnSupprimerCategorie.Name = "btnSupprimerCategorie";
            this.btnSupprimerCategorie.Size = new System.Drawing.Size(170, 34);
            this.btnSupprimerCategorie.TabIndex = 4;
            this.btnSupprimerCategorie.Text = "Supprimer";
            this.btnSupprimerCategorie.UseVisualStyleBackColor = false;
            // 
            // dataGridViewCategorie
            // 
            this.dataGridViewCategorie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCategorie.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewCategorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategorie.Location = new System.Drawing.Point(358, 27);
            this.dataGridViewCategorie.Name = "dataGridViewCategorie";
            this.dataGridViewCategorie.RowHeadersWidth = 62;
            this.dataGridViewCategorie.RowTemplate.Height = 28;
            this.dataGridViewCategorie.Size = new System.Drawing.Size(739, 348);
            this.dataGridViewCategorie.TabIndex = 3;
            // 
            // btnAddCategorie
            // 
            this.btnAddCategorie.BackColor = System.Drawing.Color.Gray;
            this.btnAddCategorie.Location = new System.Drawing.Point(59, 211);
            this.btnAddCategorie.Name = "btnAddCategorie";
            this.btnAddCategorie.Size = new System.Drawing.Size(170, 34);
            this.btnAddCategorie.TabIndex = 2;
            this.btnAddCategorie.Text = "Enregistrer";
            this.btnAddCategorie.UseVisualStyleBackColor = false;
            this.btnAddCategorie.Click += new System.EventHandler(this.btnAddCategorie_Click);
            // 
            // txtLibelleCategorie
            // 
            this.txtLibelleCategorie.Location = new System.Drawing.Point(59, 88);
            this.txtLibelleCategorie.Multiline = true;
            this.txtLibelleCategorie.Name = "txtLibelleCategorie";
            this.txtLibelleCategorie.Size = new System.Drawing.Size(198, 36);
            this.txtLibelleCategorie.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Libelle";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnModifierProducts);
            this.tabPage2.Controls.Add(this.btnSupprimerProducts);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.dataGridViewProducts);
            this.tabPage2.Controls.Add(this.btnAddProducts);
            this.tabPage2.Controls.Add(this.txtPrice);
            this.tabPage2.Controls.Add(this.txtLibelleProducts);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1138, 468);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnModifierProducts
            // 
            this.btnModifierProducts.BackColor = System.Drawing.Color.RosyBrown;
            this.btnModifierProducts.Location = new System.Drawing.Point(480, 410);
            this.btnModifierProducts.Name = "btnModifierProducts";
            this.btnModifierProducts.Size = new System.Drawing.Size(186, 39);
            this.btnModifierProducts.TabIndex = 12;
            this.btnModifierProducts.Text = "Modifier";
            this.btnModifierProducts.UseVisualStyleBackColor = false;
            // 
            // btnSupprimerProducts
            // 
            this.btnSupprimerProducts.BackColor = System.Drawing.Color.IndianRed;
            this.btnSupprimerProducts.Location = new System.Drawing.Point(794, 410);
            this.btnSupprimerProducts.Name = "btnSupprimerProducts";
            this.btnSupprimerProducts.Size = new System.Drawing.Size(186, 39);
            this.btnSupprimerProducts.TabIndex = 11;
            this.btnSupprimerProducts.Text = "Supprimer";
            this.btnSupprimerProducts.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(184, 237);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(208, 28);
            this.comboBox1.TabIndex = 10;
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(480, 44);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.RowHeadersWidth = 62;
            this.dataGridViewProducts.RowTemplate.Height = 28;
            this.dataGridViewProducts.Size = new System.Drawing.Size(619, 341);
            this.dataGridViewProducts.TabIndex = 9;
            // 
            // btnAddProducts
            // 
            this.btnAddProducts.BackColor = System.Drawing.Color.Silver;
            this.btnAddProducts.Location = new System.Drawing.Point(184, 346);
            this.btnAddProducts.Name = "btnAddProducts";
            this.btnAddProducts.Size = new System.Drawing.Size(186, 39);
            this.btnAddProducts.TabIndex = 8;
            this.btnAddProducts.Text = "Enregistrer";
            this.btnAddProducts.UseVisualStyleBackColor = false;
            this.btnAddProducts.Click += new System.EventHandler(this.btnAddProducts_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(184, 136);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(208, 40);
            this.txtPrice.TabIndex = 7;
            this.txtPrice.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrice_Validating);
            // 
            // txtLibelleProducts
            // 
            this.txtLibelleProducts.Location = new System.Drawing.Point(184, 44);
            this.txtLibelleProducts.Multiline = true;
            this.txtLibelleProducts.Name = "txtLibelleProducts";
            this.txtLibelleProducts.Size = new System.Drawing.Size(208, 40);
            this.txtLibelleProducts.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 29);
            this.label5.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Categories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Libelle";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 591);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategorie)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewCategorie;
        private System.Windows.Forms.Button btnAddCategorie;
        private System.Windows.Forms.TextBox txtLibelleCategorie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Button btnAddProducts;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtLibelleProducts;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnModifierCategorie;
        private System.Windows.Forms.Button btnSupprimerCategorie;
        private System.Windows.Forms.Button btnModifierProducts;
        private System.Windows.Forms.Button btnSupprimerProducts;
    }
}

