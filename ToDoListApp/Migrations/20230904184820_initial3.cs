using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoListApp.Migrations
{
    /// <inheritdoc />
    public partial class initial3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_task_todo-list_todo_list_id",
                table: "task");

            migrationBuilder.DropPrimaryKey(
                name: "PK_todo-list",
                table: "todo-list");

            migrationBuilder.DropPrimaryKey(
                name: "PK_task",
                table: "task");

            migrationBuilder.RenameTable(
                name: "todo-list",
                newName: "ToDoLists");

            migrationBuilder.RenameTable(
                name: "task",
                newName: "Tasks");

            migrationBuilder.RenameIndex(
                name: "IX_task_todo_list_id",
                table: "Tasks",
                newName: "IX_Tasks_todo_list_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ToDoLists",
                table: "ToDoLists",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_ToDoLists_todo_list_id",
                table: "Tasks",
                column: "todo_list_id",
                principalTable: "ToDoLists",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_ToDoLists_todo_list_id",
                table: "Tasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ToDoLists",
                table: "ToDoLists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks");

            migrationBuilder.RenameTable(
                name: "ToDoLists",
                newName: "todo-list");

            migrationBuilder.RenameTable(
                name: "Tasks",
                newName: "task");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_todo_list_id",
                table: "task",
                newName: "IX_task_todo_list_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_todo-list",
                table: "todo-list",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_task",
                table: "task",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_task_todo-list_todo_list_id",
                table: "task",
                column: "todo_list_id",
                principalTable: "todo-list",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
