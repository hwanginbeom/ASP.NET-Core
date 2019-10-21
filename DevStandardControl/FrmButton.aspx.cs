using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System;

/*
5.8 | 실습_ Button 컨트롤을 사용해 명령어 실행하기
5.8.1 소개

버튼 컨트롤은 사용 빈도가 꽤 높다. 이 실습에서는 버튼을 클릭할 때마다 텍스트박스에 있는 숫자 값을 1 증가시키거나 1 감소시키는 코드를 작성해보자.
     */

namespace DevStandardControl
{
    public partial class FrmButton : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
  //              txtNum.Text = "0"; // 처음 로드할 때만 0으로 초기화
            }
        }
        protected void btnUp_Click(object sender, EventArgs e)
        {
  //          txtNum.Text =
  //              Convert.ToString(Convert.ToInt32(txtNum.Text) + 1);
        }
        protected void btnDown_Click(object sender, EventArgs e)
        {
     //       txtNum.Text =
     //           Convert.ToString(int.Parse(txtNum.Text) - 1);
        }
    }
}

