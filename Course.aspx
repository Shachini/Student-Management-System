<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Course.aspx.cs" Inherits="StudentManagementSystem.Course" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row pb-4">
            <!--image section-->
            <div class="col-md-6 mt-1">
                <asp:Image ID="Image1" runat="server" src="./images/image3.jpg" class="img-fluid" alt="..."/>
            </div>
            <!--form section-->
            <div class="col-md-6">
                <div class="Course-forms mt-5">
                    <h2><strong>Course Information</strong></h2>

                    <!--success message-->
                    <div class="form-group">
                        <asp:Label ID="SuccessLabel" runat="server" Visible="false"></asp:Label>
                    </div>

                    <!--success message-->
                    <div class="form-group pt-3">
                        <label for="courseid"><b>Course ID</b></label>
                        <asp:TextBox ID="TextBox1" runat="server" class="form-control" placeholder="1"></asp:TextBox>
                   </div>
                    <!--success message-->
                   <div class="form-group">
                        <label for="coursename"><b>Course Name</b></label>
                        <asp:TextBox ID="TextBox2" runat="server" class="form-control" placeholder="Python"></asp:TextBox>
                   </div>
                    <!--success message-->
                    <div class="form-group">
                        <label for="lecturername"><b>Lecturer Name</b></label>
                        <asp:TextBox ID="TextBox3" runat="server" class="form-control" placeholder="N.M.Perera"></asp:TextBox>
                   </div>
                    <!--submit button-->
                    <div class="button mt-4 ml-5 pl-5">
                        <asp:Button ID="Button1" runat="server" Text="Submit" BackColor="#F5F5DC" ForeColor="black" class="btn custom-button pt-2 pl-5 pb-2 pr-5 " OnClick="Button1_Click" /> 
                    </div>
                  
                </div>
            </div>
            
        </div>
    </div>
</asp:Content>
