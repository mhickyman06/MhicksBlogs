using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MhicksBlog.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    UrlSeo = table.Column<string>(nullable: false),
                    Description = table.Column<string>(maxLength: 20, nullable: false),
                    Checked = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Imgs",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    UrlSeo = table.Column<string>(maxLength: 30, nullable: false),
                    Checked = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imgs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    ShortDescription = table.Column<string>(maxLength: 150, nullable: false),
                    Body = table.Column<string>(nullable: false),
                    Meta = table.Column<string>(maxLength: 15, nullable: false),
                    UrlSeo = table.Column<string>(nullable: false),
                    Published = table.Column<bool>(nullable: false),
                    BlogCount = table.Column<int>(nullable: false),
                    DatePublished = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    PostId = table.Column<string>(nullable: true),
                    DateTime = table.Column<DateTime>(nullable: false),
                    Username = table.Column<string>(nullable: true),
                    Body = table.Column<string>(maxLength: 1000, nullable: false),
                    CommentCount = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PostCategories",
                columns: table => new
                {
                    Postid = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    Checked = table.Column<bool>(nullable: false),
                    CategoryId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostCategories", x => new { x.Postid, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_PostCategories_Categories_CategoryId1",
                        column: x => x.CategoryId1,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostCategories_Posts_Postid",
                        column: x => x.Postid,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostImgs",
                columns: table => new
                {
                    PostId = table.Column<string>(nullable: false),
                    TagId = table.Column<string>(nullable: false),
                    Checked = table.Column<bool>(nullable: false),
                    ImgId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostImgs", x => new { x.PostId, x.TagId });
                    table.ForeignKey(
                        name: "FK_PostImgs_Imgs_ImgId",
                        column: x => x.ImgId,
                        principalTable: "Imgs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostImgs_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostLikes",
                columns: table => new
                {
                    PostId = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    Like = table.Column<bool>(nullable: false),
                    Dislike = table.Column<bool>(nullable: false),
                    PostId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostLikes", x => x.PostId);
                    table.ForeignKey(
                        name: "FK_PostLikes_Posts_PostId1",
                        column: x => x.PostId1,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PostVideos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VideoUrl = table.Column<string>(nullable: false),
                    PostId = table.Column<string>(nullable: true),
                    VideoThumbNail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostVideos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostVideos_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Commentlikes",
                columns: table => new
                {
                    CommentId = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    Like = table.Column<bool>(nullable: false),
                    DisLike = table.Column<bool>(nullable: false),
                    CommentId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commentlikes", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Commentlikes_Comments_CommentId1",
                        column: x => x.CommentId1,
                        principalTable: "Comments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Replies",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    PostID = table.Column<string>(nullable: true),
                    CommentID = table.Column<string>(nullable: true),
                    ParentReplyId = table.Column<string>(nullable: true),
                    DateTime = table.Column<DateTime>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    Body = table.Column<string>(maxLength: 1000, nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Replies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Replies_Comments_CommentID",
                        column: x => x.CommentID,
                        principalTable: "Comments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Replies_Posts_PostID",
                        column: x => x.PostID,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Replylikes",
                columns: table => new
                {
                    ReplyId = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    Like = table.Column<bool>(nullable: false),
                    DisLike = table.Column<bool>(nullable: false),
                    ReplyId1 = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Replylikes", x => x.ReplyId);
                    table.ForeignKey(
                        name: "FK_Replylikes_Replies_ReplyId1",
                        column: x => x.ReplyId1,
                        principalTable: "Replies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Commentlikes_CommentId1",
                table: "Commentlikes",
                column: "CommentId1");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_PostCategories_CategoryId1",
                table: "PostCategories",
                column: "CategoryId1");

            migrationBuilder.CreateIndex(
                name: "IX_PostImgs_ImgId",
                table: "PostImgs",
                column: "ImgId");

            migrationBuilder.CreateIndex(
                name: "IX_PostLikes_PostId1",
                table: "PostLikes",
                column: "PostId1");

            migrationBuilder.CreateIndex(
                name: "IX_PostVideos_PostId",
                table: "PostVideos",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Replies_CommentID",
                table: "Replies",
                column: "CommentID");

            migrationBuilder.CreateIndex(
                name: "IX_Replies_PostID",
                table: "Replies",
                column: "PostID");

            migrationBuilder.CreateIndex(
                name: "IX_Replylikes_ReplyId1",
                table: "Replylikes",
                column: "ReplyId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Commentlikes");

            migrationBuilder.DropTable(
                name: "PostCategories");

            migrationBuilder.DropTable(
                name: "PostImgs");

            migrationBuilder.DropTable(
                name: "PostLikes");

            migrationBuilder.DropTable(
                name: "PostVideos");

            migrationBuilder.DropTable(
                name: "Replylikes");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Imgs");

            migrationBuilder.DropTable(
                name: "Replies");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
