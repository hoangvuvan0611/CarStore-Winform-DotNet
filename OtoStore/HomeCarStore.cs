using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace OtoStore
{
    public partial class HomeCarStore : Form
    {
        public HomeCarStore()
        {
            InitializeComponent();
        }

        //String be used to open connect
        string strConnect = "Data Source=MSIHOANG;Initial Catalog=CarStore;Integrated Security=True";

        //object connect
        SqlConnection sqlConnection = null;

        private void openConnect()
        {
            try
            {
                if(sqlConnection == null)
                    sqlConnection = new SqlConnection(strConnect);

                if(sqlConnection.State == ConnectionState.Closed)
                    sqlConnection.Open();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void closeConnect()
        {
            try
            {
                if(sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //size of page
        int pageIndex = 1;
        int pageSize = 4;
        int recordCount = 0;
        int totalPage = 0;
        string nameToSearch = "";

        string company = "";
        string color = "";
        int price = 0;
        string carClass = "";
        int date = 0;

        string strSort = "";
 

        private void showListCar()
        {
            lvProduct.Items.Clear();
            lvProduct.LargeImageList = null;

            try
            {
                openConnect();


                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.StoredProcedure;
                DataTable dataTable = new DataTable();
                if (nameToSearch != "")
                {
                    sqlCmd.CommandText = "SearchForName";

                    sqlCmd.Connection = sqlConnection;

                    sqlCmd.Parameters.AddWithValue("@PageIndex", pageIndex);
                    sqlCmd.Parameters.AddWithValue("@PageSize", pageSize);
                    sqlCmd.Parameters.AddWithValue("@Name", nameToSearch);

                    sqlCmd.Parameters.Add("@RecordCount", SqlDbType.Int, 4);
                    sqlCmd.Parameters["@RecordCount"].Direction = ParameterDirection.Output;

                    //execution query
                    SqlDataReader reader = sqlCmd.ExecuteReader();
                    dataTable.Load(reader);

                    reader.Close();

                } 
                else if (company != "" || color != "" || carClass != "" || price > 0 || date > 0)
                {
                    sqlCmd.CommandText = "Filter";

                    sqlCmd.Connection = sqlConnection;

                    sqlCmd.Parameters.AddWithValue("@PageIndex", pageIndex);
                    sqlCmd.Parameters.AddWithValue("@PageSize", pageSize);
                    sqlCmd.Parameters.AddWithValue("@Company", company);
                    sqlCmd.Parameters.AddWithValue("@Color", color);
                    sqlCmd.Parameters.AddWithValue("@CarClass", carClass);
                    sqlCmd.Parameters.AddWithValue("@Date", date);
                    sqlCmd.Parameters.AddWithValue("@Price", price);

                    sqlCmd.Parameters.Add("@RecordCount", SqlDbType.Int, 4);
                    sqlCmd.Parameters["@RecordCount"].Direction = ParameterDirection.Output;

                    //execution query
                    SqlDataReader reader = sqlCmd.ExecuteReader();
                    dataTable.Load(reader);

                    reader.Close();
                }
                else
                {
                    sqlCmd.CommandText = "GetListCar";

                    sqlCmd.Connection = sqlConnection;

                    sqlCmd.Parameters.AddWithValue("@PageIndex", pageIndex);
                    sqlCmd.Parameters.AddWithValue("@PageSize", pageSize);

                    sqlCmd.Parameters.Add("@RecordCount", SqlDbType.Int, 4);
                    sqlCmd.Parameters["@RecordCount"].Direction = ParameterDirection.Output;

                    //execution query
                    SqlDataReader reader = sqlCmd.ExecuteReader();
                    dataTable.Load(reader);

                    reader.Close();
                }

                recordCount = Convert.ToInt32(sqlCmd.Parameters["@RecordCount"].Value);

                getTotalPage();
                setupBtnPage();

                //Sort in page
                DataView dv = dataTable.DefaultView;
                dv.Sort = strSort;

                dataTable = dv.ToTable();

                ImageList carImageList = new ImageList();
                carImageList.ImageSize = new Size(256, 150);
                carImageList.ColorDepth = ColorDepth.Depth24Bit;

                lvProduct.View = View.LargeIcon;
                lvProduct.TileSize = new Size(500, 500);
               
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    DataRow drow = dataTable.Rows[i];

                    // Only row that have not been deleted
                    if (drow.RowState != DataRowState.Deleted)
                    {
                        // Define the list items
                        ListViewItem lvi = new ListViewItem(
                            "Mẫu xe: " + drow["name"].ToString()
                            + "\nHãng xe: " + drow["nameCompany"].ToString()
                            + "\nMàu sắc: " + drow["nameColor"].ToString()
                            + "\nNăm sản xuất: " + drow["date"].ToString()
                            + "\nGiá: " + drow["price"].ToString()
                        );

                        /*                       Image img = Image.FromFile(drow["image"].ToString());*/
                        carImageList.Images.Add(Image.FromFile(drow["image"].ToString()));

                        lvProduct.LargeImageList = carImageList;

                        // Add the list items to the ListView
                        lvProduct.Items.Add(lvi.Text, i);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void lvProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HomeCarStore_Load(object sender, EventArgs e)
        {
            showListCar();
        }

        private void getTotalPage()
        {
            int temp = recordCount % pageSize;
            if (temp != 0)
                totalPage = (recordCount / pageSize) + 1;
            else
                totalPage = recordCount / pageSize;

            if (recordCount <= pageSize)
                totalPage = 1;

            lbPageIndex.Text = "Trang " + pageIndex.ToString() + "/" + (totalPage);
            lbCountCar.Text = recordCount.ToString() + " sản phẩm";
        }

        private void setupBtnPage()
        {
            if(totalPage == 1)
            {
                btnPage2.Enabled = false;
                btnNextPage.Enabled = false;
                btnLastPage.Enabled = false;
                btnPreviousPage.Enabled = false;
                btnPage1.Enabled = false;
            }
            else
            {
                btnPage2.Enabled = true;
                btnNextPage.Enabled = true;
                btnLastPage.Enabled = true;
                btnPreviousPage.Enabled = true;
                btnPage1.Enabled = true;
            }

            if(pageIndex == 1)
                btnPreviousPage.Enabled = false;
            else
                btnPreviousPage.Enabled = true;

            if (pageIndex == totalPage) {
                btnNextPage.Enabled = false;
                btnLastPage.Enabled = false;
            }
            else
            {
                btnNextPage.Enabled = true;
                btnLastPage.Enabled = true;
            }
            
        }

        private void btnPage1_Click(object sender, EventArgs e)
        {
            pageIndex = 1;
            btnPreviousPage.Enabled = false;
            showListCar();
        }

        private void btnPage2_Click(object sender, EventArgs e)
        {
            pageIndex = 2;
            showListCar();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
                pageIndex++;
                showListCar();
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            pageIndex--;
            showListCar();
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            pageIndex = totalPage;
            showListCar();
            btnNextPage.Enabled = false;
            btnLastPage.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            nameToSearch = txtSearch.Text;
            showListCar();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string cpn = (string)cbCompany.SelectedItem;
            string cl = (string)cbColor.SelectedItem;
            string pr = (string)cbPriceOfFilter.SelectedItem;
            string d = (string)cbDateOfFilter.SelectedItem;
            string cla = (string)cbClass.SelectedItem;

            if (cpn == null)
                company = "";
            else
                company = cpn;

            if (cl == null)
                color = "";
            else
            {
                switch (cl)
                {
                    case "Đen":
                        color = "black";
                        break;
                    case "Trắng":
                        color = "white";
                        break;
                    case "Đỏ":
                        color = "red";
                        break;
                    case "Bạc":
                        color = "sliver";
                        break;
                    case "Xám":
                        color = "Gray";
                        break;
                    default:
                        color = "";
                        break;
                }
            } 
                


            if (pr == null)
                price = 0;
            else
                price = int.Parse(pr);

            if (d == null)
                date = 0;
            else
                date = int.Parse(d);

            if (cla == null)
                carClass = "";
            else
                carClass = cla;

            nameToSearch = "";
            showListCar();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cbCompany.SelectedIndex = -1;
            cbCompany.Text = "Hãng xe";
            company = "";

            cbClass.SelectedIndex = -1;
            cbClass.Text = "Hạng xe";
            carClass = "";

            cbColor.SelectedIndex = -1;
            cbColor.Text = "Màu xe";
            color = "";

            cbPriceOfFilter.SelectedIndex = -1;
            cbPriceOfFilter.Text = "Mức giá";
            price = 0;

            cbDateOfFilter.SelectedIndex = -1;
            cbDateOfFilter.Text = "Năm sản xuất";
            date = 0;

            showListCar();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            string sortByPrice = (string)cbPriceOfSort.SelectedItem;
            string sortByDate = (string)cbDateOfSort.SelectedItem;

            if (sortByDate == "Tăng dần")
                sortByDate = "date asc";
            else if (sortByDate == "Giảm dần")
                sortByDate = "date desc";
            else
                sortByDate = "";

            if (sortByPrice == "Tăng dần")
                sortByPrice = "date asc";
            else if (sortByPrice == "Giảm dần")
                sortByPrice = "date desc";
            else
                sortByPrice = "";

            if(sortByDate != "" && sortByPrice != "")
                strSort = sortByDate + " , " + sortByPrice;
            else
                strSort = sortByDate + sortByPrice;

            showListCar();
        }
    }
}
