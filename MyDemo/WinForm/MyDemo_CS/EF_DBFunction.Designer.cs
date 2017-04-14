namespace MyDemo_CS
{
    partial class EF_DBFunction
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
            this.SelectDataTable = new System.Windows.Forms.Button();
            this.Selectlist = new System.Windows.Forms.Button();
            this.BulkInsert = new System.Windows.Forms.Button();
            this.InsertT = new System.Windows.Forms.Button();
            this.InsertBySql = new System.Windows.Forms.Button();
            this.UpdateList = new System.Windows.Forms.Button();
            this.UpdateT = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnUpdateExpression = new System.Windows.Forms.Button();
            this.DeleteList = new System.Windows.Forms.Button();
            this.DeleteExpression = new System.Windows.Forms.Button();
            this.DeleteT = new System.Windows.Forms.Button();
            this.DeleteBySql = new System.Windows.Forms.Button();
            this.InsertOutLastInsertID = new System.Windows.Forms.Button();
            this.SelectListPage = new System.Windows.Forms.Button();
            this.btnSelectOne = new System.Windows.Forms.Button();
            this.btnSelectOneColumn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectDataTable
            // 
            this.SelectDataTable.Location = new System.Drawing.Point(29, 233);
            this.SelectDataTable.Name = "SelectDataTable";
            this.SelectDataTable.Size = new System.Drawing.Size(162, 23);
            this.SelectDataTable.TabIndex = 0;
            this.SelectDataTable.Text = "SelectDataTable";
            this.SelectDataTable.UseVisualStyleBackColor = true;
            this.SelectDataTable.Click += new System.EventHandler(this.SelectDataTable_Click);
            // 
            // Selectlist
            // 
            this.Selectlist.Location = new System.Drawing.Point(251, 233);
            this.Selectlist.Name = "Selectlist";
            this.Selectlist.Size = new System.Drawing.Size(193, 23);
            this.Selectlist.TabIndex = 1;
            this.Selectlist.Text = "SelectList(SQL：分页带总数)";
            this.Selectlist.UseVisualStyleBackColor = true;
            this.Selectlist.Click += new System.EventHandler(this.Selectlist_Click);
            // 
            // BulkInsert
            // 
            this.BulkInsert.Location = new System.Drawing.Point(29, 23);
            this.BulkInsert.Name = "BulkInsert";
            this.BulkInsert.Size = new System.Drawing.Size(162, 23);
            this.BulkInsert.TabIndex = 2;
            this.BulkInsert.Text = "BulkInsert(EF批量导入)";
            this.BulkInsert.UseVisualStyleBackColor = true;
            this.BulkInsert.Click += new System.EventHandler(this.BulkInsert_Click);
            // 
            // InsertT
            // 
            this.InsertT.Location = new System.Drawing.Point(251, 23);
            this.InsertT.Name = "InsertT";
            this.InsertT.Size = new System.Drawing.Size(167, 23);
            this.InsertT.TabIndex = 3;
            this.InsertT.Text = "Insert<T>";
            this.InsertT.UseVisualStyleBackColor = true;
            this.InsertT.Click += new System.EventHandler(this.InsertT_Click);
            // 
            // InsertBySql
            // 
            this.InsertBySql.Location = new System.Drawing.Point(473, 23);
            this.InsertBySql.Name = "InsertBySql";
            this.InsertBySql.Size = new System.Drawing.Size(165, 23);
            this.InsertBySql.TabIndex = 4;
            this.InsertBySql.Text = "Insert（Sql）";
            this.InsertBySql.UseVisualStyleBackColor = true;
            this.InsertBySql.Click += new System.EventHandler(this.InsertBySql_Click);
            // 
            // UpdateList
            // 
            this.UpdateList.Location = new System.Drawing.Point(29, 86);
            this.UpdateList.Name = "UpdateList";
            this.UpdateList.Size = new System.Drawing.Size(162, 23);
            this.UpdateList.TabIndex = 2;
            this.UpdateList.Text = "Update(List<T>)";
            this.UpdateList.UseVisualStyleBackColor = true;
            this.UpdateList.Click += new System.EventHandler(this.UpdateList_Click);
            // 
            // UpdateT
            // 
            this.UpdateT.Location = new System.Drawing.Point(251, 86);
            this.UpdateT.Name = "UpdateT";
            this.UpdateT.Size = new System.Drawing.Size(167, 23);
            this.UpdateT.TabIndex = 3;
            this.UpdateT.Text = "Update<T>";
            this.UpdateT.UseVisualStyleBackColor = true;
            this.UpdateT.Click += new System.EventHandler(this.UpdateT_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(473, 86);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Update（Sql）";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnUpdateExpression
            // 
            this.btnUpdateExpression.Location = new System.Drawing.Point(683, 86);
            this.btnUpdateExpression.Name = "btnUpdateExpression";
            this.btnUpdateExpression.Size = new System.Drawing.Size(162, 23);
            this.btnUpdateExpression.TabIndex = 2;
            this.btnUpdateExpression.Text = "Update(表达式批量更新)";
            this.btnUpdateExpression.UseVisualStyleBackColor = true;
            this.btnUpdateExpression.Click += new System.EventHandler(this.btnUpdateExpression_Click);
            // 
            // DeleteList
            // 
            this.DeleteList.Location = new System.Drawing.Point(29, 151);
            this.DeleteList.Name = "DeleteList";
            this.DeleteList.Size = new System.Drawing.Size(162, 23);
            this.DeleteList.TabIndex = 2;
            this.DeleteList.Text = "Delete(List<T>)";
            this.DeleteList.UseVisualStyleBackColor = true;
            this.DeleteList.Click += new System.EventHandler(this.DeleteList_Click);
            // 
            // DeleteExpression
            // 
            this.DeleteExpression.Location = new System.Drawing.Point(683, 151);
            this.DeleteExpression.Name = "DeleteExpression";
            this.DeleteExpression.Size = new System.Drawing.Size(162, 23);
            this.DeleteExpression.TabIndex = 2;
            this.DeleteExpression.Text = "Delete(表达式批量更新)";
            this.DeleteExpression.UseVisualStyleBackColor = true;
            this.DeleteExpression.Click += new System.EventHandler(this.DeleteExpression_Click);
            // 
            // DeleteT
            // 
            this.DeleteT.Location = new System.Drawing.Point(251, 151);
            this.DeleteT.Name = "DeleteT";
            this.DeleteT.Size = new System.Drawing.Size(167, 23);
            this.DeleteT.TabIndex = 3;
            this.DeleteT.Text = "Delete<T>";
            this.DeleteT.UseVisualStyleBackColor = true;
            this.DeleteT.Click += new System.EventHandler(this.DeleteT_Click);
            // 
            // DeleteBySql
            // 
            this.DeleteBySql.Location = new System.Drawing.Point(473, 151);
            this.DeleteBySql.Name = "DeleteBySql";
            this.DeleteBySql.Size = new System.Drawing.Size(165, 23);
            this.DeleteBySql.TabIndex = 4;
            this.DeleteBySql.Text = "Delete（Sql）";
            this.DeleteBySql.UseVisualStyleBackColor = true;
            this.DeleteBySql.Click += new System.EventHandler(this.DeleteBySql_Click);
            // 
            // InsertOutLastInsertID
            // 
            this.InsertOutLastInsertID.Location = new System.Drawing.Point(683, 23);
            this.InsertOutLastInsertID.Name = "InsertOutLastInsertID";
            this.InsertOutLastInsertID.Size = new System.Drawing.Size(237, 23);
            this.InsertOutLastInsertID.TabIndex = 5;
            this.InsertOutLastInsertID.Text = "Insert<T>(out lastInsertID)";
            this.InsertOutLastInsertID.UseVisualStyleBackColor = true;
            this.InsertOutLastInsertID.Click += new System.EventHandler(this.InsertOutLastInsertID_Click);
            // 
            // SelectListPage
            // 
            this.SelectListPage.Location = new System.Drawing.Point(473, 233);
            this.SelectListPage.Name = "SelectListPage";
            this.SelectListPage.Size = new System.Drawing.Size(196, 23);
            this.SelectListPage.TabIndex = 1;
            this.SelectListPage.Text = "SelectList(T：分页带总数)";
            this.SelectListPage.UseVisualStyleBackColor = true;
            this.SelectListPage.Click += new System.EventHandler(this.SelectListPage_Click);
            // 
            // btnSelectOne
            // 
            this.btnSelectOne.Location = new System.Drawing.Point(29, 292);
            this.btnSelectOne.Name = "btnSelectOne";
            this.btnSelectOne.Size = new System.Drawing.Size(162, 23);
            this.btnSelectOne.TabIndex = 0;
            this.btnSelectOne.Text = "SelectOne";
            this.btnSelectOne.UseVisualStyleBackColor = true;
            this.btnSelectOne.Click += new System.EventHandler(this.btnSelectOne_Click);
            // 
            // btnSelectOneColumn
            // 
            this.btnSelectOneColumn.Location = new System.Drawing.Point(251, 292);
            this.btnSelectOneColumn.Name = "btnSelectOneColumn";
            this.btnSelectOneColumn.Size = new System.Drawing.Size(162, 23);
            this.btnSelectOneColumn.TabIndex = 0;
            this.btnSelectOneColumn.Text = "SelectOneColumn";
            this.btnSelectOneColumn.UseVisualStyleBackColor = true;
            this.btnSelectOneColumn.Click += new System.EventHandler(this.btnSelectOneColumn_Click);
            // 
            // EF_DBFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 487);
            this.Controls.Add(this.InsertOutLastInsertID);
            this.Controls.Add(this.DeleteBySql);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.InsertBySql);
            this.Controls.Add(this.DeleteT);
            this.Controls.Add(this.DeleteExpression);
            this.Controls.Add(this.UpdateT);
            this.Controls.Add(this.DeleteList);
            this.Controls.Add(this.btnUpdateExpression);
            this.Controls.Add(this.UpdateList);
            this.Controls.Add(this.InsertT);
            this.Controls.Add(this.BulkInsert);
            this.Controls.Add(this.SelectListPage);
            this.Controls.Add(this.Selectlist);
            this.Controls.Add(this.btnSelectOneColumn);
            this.Controls.Add(this.btnSelectOne);
            this.Controls.Add(this.SelectDataTable);
            this.Name = "EF_DBFunction";
            this.Text = "EF_DBFunction";
            this.Load += new System.EventHandler(this.EF_DBFunction_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SelectDataTable;
        private System.Windows.Forms.Button Selectlist;
        private System.Windows.Forms.Button BulkInsert;
        private System.Windows.Forms.Button InsertT;
        private System.Windows.Forms.Button InsertBySql;
        private System.Windows.Forms.Button UpdateList;
        private System.Windows.Forms.Button UpdateT;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnUpdateExpression;
        private System.Windows.Forms.Button DeleteList;
        private System.Windows.Forms.Button DeleteExpression;
        private System.Windows.Forms.Button DeleteT;
        private System.Windows.Forms.Button DeleteBySql;
        private System.Windows.Forms.Button InsertOutLastInsertID;
        private System.Windows.Forms.Button SelectListPage;
        private System.Windows.Forms.Button btnSelectOne;
        private System.Windows.Forms.Button btnSelectOneColumn;
    }
}