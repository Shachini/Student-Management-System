<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="StudentManagementSystem.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row pb-4">
            <div class="col-md-6 mt-5 pt-5">
                <h1 class="custom-hero-title"><strong>Student Management <br />System</strong></h1>
                <p class="mt-4 custom-hero-para">
                    Student Management System is used to help in managing<br>
                    information of students. We use this this system to manage<br>
                    all your educational activities.
                </p>
                 <asp:Button ID="Button1" runat="server" Text="Learn more" class="btn custom-learn-button mt-3 " OnClick="Button1_Click" BackColor="#F5F5DC" ForeColor="black"/>
            </div>
            <div class="col-md-6">
                 <asp:Image ID="Image1" runat="server" src="./images/image8.JPG" class="img-fluid" alt="..."/>
            </div>
        </div>
    </div>
</asp:Content>
