<%@ Page Title="Home Page" Language="C#" EnableEventValidation="false" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="StudentCRUDApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="LblMessage" runat="server" CssClass="text-info"></asp:Label>


     <div class="mt-4">
        <h2 class="text-center">Student Management</h2>
        <form class="p-3 bg-light rounded border">
            <div class="row g-3">
                <div class="col-md-4">
                    <label for="TxtStudentId" class="form-label">Student ID</label>
                    <asp:TextBox ID="TxtStudentId" runat="server" CssClass="form-control" />
                </div>
                <div class="col-md-4">
                    <label for="TxtStudentName" class="form-label">Student Name</label>
                    <asp:TextBox ID="TxtStudentName" runat="server" CssClass="form-control" />
                </div>
                <div class="col-md-4">
                    <label for="TxtStudentRollNo" class="form-label">Roll Number</label>
                    <asp:TextBox ID="TxtStudentRollNo" runat="server" CssClass="form-control" />
                </div>
                <div class="col-md-6">
                    <label for="TxtStudentEmail" class="form-label">Email</label>
                    <asp:TextBox ID="TxtStudentEmail" runat="server" CssClass="form-control" />
                </div>
                <div class="col-md-6">
                    <label for="TxtStudentAge" class="form-label">Age</label>
                    <asp:TextBox ID="TxtStudentAge" runat="server" CssClass="form-control" />
                </div>
            </div>
            <div class="mt-3">
                <asp:Button ID="BtnAdd" Text="Add" OnClick="BtnAdd_Click" CssClass="btn btn-primary me-2" runat="server" />
                <asp:Button ID="BtnUpdate" Text="Update" OnClick="BtnUpdate_Click" CssClass="btn btn-warning me-2" runat="server" />
                <asp:Button ID="BtnDelete" Text="Delete" OnClick="BtnDelete_Click" CssClass="btn btn-danger me-2" runat="server" />
                <asp:Button ID="BtnSearch" Text="Search" OnClick="BtnSearch_Click" CssClass="btn btn-secondary" runat="server" />
                <asp:Button ID="BtnClear" Text="Clear" OnClick="BtnClear_Click" CssClass="btn btn-secondary" runat="server" />


            </div>
        </form>
        <div class="mt-4">
            <asp:GridView ID="GridViewStudents" runat="server" CssClass="table table-striped table-bordered" />
        </div>
    </div>
</asp:Content>
