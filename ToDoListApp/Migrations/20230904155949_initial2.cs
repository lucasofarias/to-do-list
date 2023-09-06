using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoListApp.Migrations
{
    /// <inheritdoc />
    public partial class initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_task_todo-list_ToDoListId",
                table: "task");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "todo-list",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "todo-list",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "todo-list",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "task",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "task",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "ToDoListId",
                table: "task",
                newName: "todo_list_id");

            migrationBuilder.RenameColumn(
                name: "IsCompleted",
                table: "task",
                newName: "is_completed");

            migrationBuilder.RenameIndex(
                name: "IX_task_ToDoListId",
                table: "task",
                newName: "IX_task_todo_list_id");

            migrationBuilder.AddForeignKey(
                name: "FK_task_todo-list_todo_list_id",
                table: "task",
                column: "todo_list_id",
                principalTable: "todo-list",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_task_todo-list_todo_list_id",
                table: "task");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "todo-list",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "todo-list",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "todo-list",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "task",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "task",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "todo_list_id",
                table: "task",
                newName: "ToDoListId");

            migrationBuilder.RenameColumn(
                name: "is_completed",
                table: "task",
                newName: "IsCompleted");

            migrationBuilder.RenameIndex(
                name: "IX_task_todo_list_id",
                table: "task",
                newName: "IX_task_ToDoListId");

            migrationBuilder.AddForeignKey(
                name: "FK_task_todo-list_ToDoListId",
                table: "task",
                column: "ToDoListId",
                principalTable: "todo-list",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
