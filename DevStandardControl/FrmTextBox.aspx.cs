using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


/*
 5.6 | 실습_ TextBox 컨트롤을 사용해 사용자 정보 얻어오기
5.6.1 소개

사용자에게 어떤 값을 입력 받고자 할 때 사용하는 텍스트박스 컨트롤의 세 가지 유형을 살펴보자.
     */
namespace DevStandardControl
{
    public partial class FrmTextBox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnOK_Click(object sender, EventArgs e)
        {
            // 이름 받아 오기
            string strName = this.txtSingleLine.Text;
            // 소개 받아 오기
            string strIntro = this.txtMultiLine.Text;
            // 암호 받아 오기
            string strPassword = this.txtPassword.Text;
            // 출력
            Response.Write(
                strName + "<br />"

                +strIntro + "<br />"

                +strPassword + "<br />");
        }
    }
}