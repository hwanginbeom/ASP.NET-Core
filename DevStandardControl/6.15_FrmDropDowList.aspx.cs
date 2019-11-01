using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/*
 6.13 | DropDownList 컨트롤
6.13.1 소개

드롭다운리스트 컨트롤은 HTML의 <select><option> 태그의 조합을 ASP.NET 서버 컨트롤로 구현한 컨트롤이다.

드롭다운리스트 컨트롤에 전화번호 리스트를 선언적으로 출력하고자 할 때는 다음과 같은 방식으로 작성할 수 있다
(이때 선언적으로 출력한다는 것은 태그(소스)로 직접 출력하는 것을 말한다. C# 코드에서 만들어서 출력하는 
프로그래밍적으로 출력하는 것과는 다르다). Value 속성과 Text 속성을 구분지어서 설정할 수 있는 여러 모양을 보여준다.

     */

namespace DevStandardControl
{
    public partial class _6__15_erwer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack && lstJob.Items.Count > 1)
            {
                this.lstJob.SelectedIndex = 1;
            }
        }

        protected void lstJob_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 문자열 변수 선언과 동시 초기화
            string strMsg = String.Empty;
            strMsg =
                lstJob.SelectedItem.Text
                + "을(를) 선택하셨습니다.";
            // 레이블에 현재 선택된 값 출력
            this.lblDisplay.Text = strMsg;
        }
    }
    
}