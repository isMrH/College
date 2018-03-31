using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BooksManager.BLL;
using BooksManager.Model;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!Page.IsPostBack)
        {
            ddlProvince.DataSource = ProvinceManager.GetAllProvinces();
            ddlProvince.DataTextField = "provinceName";
            ddlProvince.DataValueField = "provinceId";
            ddlProvince.DataBind();//数据绑定
            DisPlayCity();
        }

    }
    public void DisPlayCity()//绑定省份所对应的城市信息
    {
        int provid = int.Parse(ddlProvince.SelectedItem.Value);
        ddlCity.DataSource = CityManager.GetCitiesByProvinceId(provid);
        ddlCity.DataTextField = "cityName";
        ddlCity.DataValueField = "cityId";
        ddlCity.DataBind();
    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        string sex = rdolistSex.SelectedValue.ToString();//获取选中的性别
        string favorite="";
        string province = ddlProvince.SelectedItem.Text;
        string city = ddlCity.SelectedItem.Text;
        
        foreach(ListItem item in cblLove.Items)//获取选中的爱好
        {
            if(item.Selected)
            {
                favorite+=item.Text+";";
            }
        }
        int obj = Convert.ToInt32(UserManager.GetUserByName(txtName.Text));
        if (obj > 0)
        {
            Response.Write("<script>alert('用户名已使用！')</script>");
            return;
        }
        if (txtPwd.Text != txtTruepwd.Text)
        {
            Response.Write("<script>alert('两次密码输入不一致！')</script>");
            return;
        }
        if (sex == "" || favorite == "" || province == "" || city == "" || txtAddress.Text == "" || txtPwd.Text == "")
        {
            Response.Write("<script>alert('请填写完整信息！')</script>");
            return;
        }
        Users u = new Users();
        u.Name = txtName.Text;
        u.Password = txtPwd.Text;
        if (sex == "男")
        {
            u.Sex = 1;
        }
        else
        {
            u.Sex = 0;
        }
       
        u.Address = txtAddress.Text;
        u.Favorite = favorite;
        u.CityID = Convert.ToInt32(ddlCity.SelectedItem.Value);
        int cnt=UserManager.InsertUser(u);
        if (cnt > 0)
        {
            Response.Write("<script>alert('注册成功！')</script>");
            return;
        }
        lblmessages.Text = "你填写的信息如下：<br>" + "你的用户名为：" + txtName.Text + "<br>" + "通讯地址为：" + txtAddress.Text + "<br>" + "性别为：" + sex + "<br>" + "爱好为：" + favorite+"<br>"+"所在省份为："+province+"<br>"+"所在城市为："+city;

    }
    protected void ddlPrivate_SelectedIndexChanged(object sender, EventArgs e)
    {
        DisPlayCity();

    }
}
