using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Novatek.Migrations
{
    public partial class ScriptC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Companies_CompanyId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Designations_DesignationId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Increments_Designations_DesignationId",
                table: "Increments");

            migrationBuilder.DropForeignKey(
                name: "FK_Increments_Employees_EmployeeId",
                table: "Increments");

            migrationBuilder.DropForeignKey(
                name: "FK_Salaries_Employees_EmployeeId",
                table: "Salaries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Salaries",
                table: "Salaries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Increments",
                table: "Increments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Designations",
                table: "Designations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                table: "Departments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Companies",
                table: "Companies");

            migrationBuilder.RenameTable(
                name: "Salaries",
                newName: "Salary");

            migrationBuilder.RenameTable(
                name: "Increments",
                newName: "Increment");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Employee");

            migrationBuilder.RenameTable(
                name: "Designations",
                newName: "Designation");

            migrationBuilder.RenameTable(
                name: "Departments",
                newName: "Department");

            migrationBuilder.RenameTable(
                name: "Companies",
                newName: "Company");

            migrationBuilder.RenameIndex(
                name: "IX_Salaries_EmployeeId",
                table: "Salary",
                newName: "IX_Salary_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Increments_EmployeeId",
                table: "Increment",
                newName: "IX_Increment_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Increments_DesignationId",
                table: "Increment",
                newName: "IX_Increment_DesignationId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_DesignationId",
                table: "Employee",
                newName: "IX_Employee_DesignationId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employee",
                newName: "IX_Employee_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_CompanyId",
                table: "Employee",
                newName: "IX_Employee_CompanyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Salary",
                table: "Salary",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Increment",
                table: "Increment",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Designation",
                table: "Designation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Department",
                table: "Department",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Company",
                table: "Company",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Company_CompanyId",
                table: "Employee",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Department_DepartmentId",
                table: "Employee",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Designation_DesignationId",
                table: "Employee",
                column: "DesignationId",
                principalTable: "Designation",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Increment_Designation_DesignationId",
                table: "Increment",
                column: "DesignationId",
                principalTable: "Designation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Increment_Employee_EmployeeId",
                table: "Increment",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Salary_Employee_EmployeeId",
                table: "Salary",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Company_CompanyId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Department_DepartmentId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Designation_DesignationId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Increment_Designation_DesignationId",
                table: "Increment");

            migrationBuilder.DropForeignKey(
                name: "FK_Increment_Employee_EmployeeId",
                table: "Increment");

            migrationBuilder.DropForeignKey(
                name: "FK_Salary_Employee_EmployeeId",
                table: "Salary");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Salary",
                table: "Salary");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Increment",
                table: "Increment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Designation",
                table: "Designation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Department",
                table: "Department");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Company",
                table: "Company");

            migrationBuilder.RenameTable(
                name: "Salary",
                newName: "Salaries");

            migrationBuilder.RenameTable(
                name: "Increment",
                newName: "Increments");

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "Employees");

            migrationBuilder.RenameTable(
                name: "Designation",
                newName: "Designations");

            migrationBuilder.RenameTable(
                name: "Department",
                newName: "Departments");

            migrationBuilder.RenameTable(
                name: "Company",
                newName: "Companies");

            migrationBuilder.RenameIndex(
                name: "IX_Salary_EmployeeId",
                table: "Salaries",
                newName: "IX_Salaries_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Increment_EmployeeId",
                table: "Increments",
                newName: "IX_Increments_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Increment_DesignationId",
                table: "Increments",
                newName: "IX_Increments_DesignationId");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_DesignationId",
                table: "Employees",
                newName: "IX_Employees_DesignationId");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_DepartmentId",
                table: "Employees",
                newName: "IX_Employees_DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_CompanyId",
                table: "Employees",
                newName: "IX_Employees_CompanyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Salaries",
                table: "Salaries",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Increments",
                table: "Increments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Designations",
                table: "Designations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                table: "Departments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Companies",
                table: "Companies",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Companies_CompanyId",
                table: "Employees",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepartmentId",
                table: "Employees",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Designations_DesignationId",
                table: "Employees",
                column: "DesignationId",
                principalTable: "Designations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Increments_Designations_DesignationId",
                table: "Increments",
                column: "DesignationId",
                principalTable: "Designations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Increments_Employees_EmployeeId",
                table: "Increments",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Salaries_Employees_EmployeeId",
                table: "Salaries",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
