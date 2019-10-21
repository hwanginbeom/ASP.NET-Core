using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/*
5.12 | 실습_ ImageButton 컨트롤을 사용해 명령어 실행하기
5.12.1 소개

단순한 버튼이 아닌 원하는 이미지를 사용해 버튼의 기능을 수행하는 이미지버튼 컨트롤을 만들어보자.
     */

namespace DevStandardControl
{
    public partial class FrmImageButton : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.imgWrite.ImageUrl =
                "/images/btn_post.gif";
            this.imgList.ImageUrl =
                "..images/btn_list.gif";
        }
        protected void imgWrite_Click(
            object sender, ImageClickEventArgs e)
        {
            Response.Write("글쓰기 버튼 클릭됨.<br />");
        }
        protected void imgList_Click(
            object sender, ImageClickEventArgs e)
        {
            Response.Write("리스트 버튼 클릭됨.<br />");
        }
    }
}