using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/*
 
6.10 | BulletedList 컨트롤
6.10.1 소개

불릿리스트 컨트롤은 HTML의 목록, 즉 글머리 기호에 해당하는 리스트 형식의 텍스트를 표현할 때 사용한다.

 

6.10.2 BulletedList 컨트롤의 주요 구성 요소

불릿리스트 컨트롤의 주요 구성 요소는 다음 표와 같다.



BulletedList - System.Web.UI.WebControls.BulletedList 클래스

속성

DisplayMode - 글머리 기호 목록에서 세 가지 형태의 모양 지정

BulletStyle - 글머리 기호에 사용할 스타일 지정

FirstBulletNumber - 순서 있는 목록의 시작 번호 값을 지정


     
     */


namespace DevStandardControl
{
    public partial class _6__11_FrmBulletedList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lstFavorite_Click(object sender, BulletedListEventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("선택한 항목: <br/>");
            sb.Append(lstFavorite.Items[e.Index].Text);
            sb.Append("<br/>");
            sb.Append(lstFavorite.Items[e.Index].Value + "<br/>");

            Response.Write(sb.ToString());
        }

    }
}