<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Students.aspx.cs" Inherits="StudentManagementSystem.Stuents" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="./css/style1.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row pb-4">
            <!--form section-->
            <div class="col-md-5">
                
                <div class="Student-forms mt-5">
                    <h2><strong>Student Information</strong></h2>

                     <!--success message-->
                    <div class="form-group">
                        <asp:Label ID="SuccessLabel" runat="server" Visible="false"></asp:Label>
                    </div>
                    
                   <!--student id-->
                   <div class="form-group pt-3">
                        <label for="studentid">Student ID</label>
                        <asp:TextBox ID="TextBox1" runat="server" class="form-control" placeholder="1"></asp:TextBox>
                   </div>
                    <!--student name-->
                   <div class="form-group">
                        <label for="studentname">Student Name</label>
                        <asp:TextBox ID="TextBox2" runat="server" class="form-control" placeholder="Shachini Perera"></asp:TextBox>
                   </div>
                    <!--city-->
                    <div class="form-group">
                        <label for="city">City</label>
                        <asp:TextBox ID="TextBox3" runat="server" class="form-control" placeholder="Colombo"></asp:TextBox>
                   </div>
                    <!--course id-->
                   <div class="form-group">
                        <label for="courseid">Course ID</label>
                        <asp:TextBox ID="TextBox4" runat="server" class="form-control" placeholder="1"></asp:TextBox>
                   </div>
                    
                    <div class="button mt-4 ml-5 pl-5">
                        <!--submit button-->
                        <asp:Button ID="Button1" runat="server" Text="Submit" BackColor="#F5F5DC" ForeColor="black" class="btn custom-button pt-2 pl-5 pb-2 pr-5 " OnClick="Button1_Click" />
                    </div>
                   
                </div>
            </div>
            <!--image section-->
            <div class="col-md-7 mt-3 pt-4">
                <asp:Image ID="Image1" runat="server" src="./images/image1.jpg" class="img-fluid" alt="..."/>
            </div>
        </div>
    </div>

</asp:Content>
