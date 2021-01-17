using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobManagement.Migrations
{
    public partial class firstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "N_BusinessSectors",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 255, nullable: true),
                    Position = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_N_BusinessSectors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "N_Educations",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 255, nullable: true),
                    Position = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_N_Educations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 255, nullable: true),
                    Position = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NCountries",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 255, nullable: true),
                    Position = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NCountries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NGenders",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 255, nullable: true),
                    Position = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NGenders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NHealthStatuses",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 255, nullable: true),
                    Position = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NHealthStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NJobTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 255, nullable: true),
                    Position = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NJobTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NSkills",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 255, nullable: true),
                    Position = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NSkills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NTowns",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 255, nullable: true),
                    Position = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NTowns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    UserType = table.Column<int>(nullable: false),
                    CompanyName = table.Column<string>(maxLength: 100, nullable: true),
                    ProfileImageStr = table.Column<string>(nullable: true),
                    NCountryId = table.Column<Guid>(nullable: true),
                    NCountryBusinessnUser = table.Column<Guid>(nullable: true),
                    NTownId = table.Column<Guid>(nullable: true),
                    NTownBusinessUser = table.Column<Guid>(nullable: true),
                    AdditionalDescription = table.Column<string>(nullable: true),
                    NBusinessSectorId = table.Column<Guid>(nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    LastName = table.Column<string>(maxLength: 100, nullable: true),
                    BdayDate = table.Column<DateTime>(nullable: true),
                    User_ProfileImageStr = table.Column<string>(nullable: true),
                    TelеphoneNumber = table.Column<string>(maxLength: 255, nullable: true),
                    VisibilityProfile = table.Column<bool>(nullable: true),
                    User_NCountryId = table.Column<Guid>(nullable: true),
                    NCountrynUser = table.Column<Guid>(nullable: true),
                    User_AdditionalDescription = table.Column<string>(nullable: true),
                    NEducationId = table.Column<Guid>(nullable: true),
                    NGenderId = table.Column<Guid>(nullable: true),
                    User_NTownId = table.Column<Guid>(nullable: true),
                    NTownUser = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_N_BusinessSectors_NBusinessSectorId",
                        column: x => x.NBusinessSectorId,
                        principalTable: "N_BusinessSectors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_NCountries_NCountryBusinessnUser",
                        column: x => x.NCountryBusinessnUser,
                        principalTable: "NCountries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_NTowns_NTownBusinessUser",
                        column: x => x.NTownBusinessUser,
                        principalTable: "NTowns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_NCountries_NCountrynUser",
                        column: x => x.NCountrynUser,
                        principalTable: "NCountries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_N_Educations_NEducationId",
                        column: x => x.NEducationId,
                        principalTable: "N_Educations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_NGenders_NGenderId",
                        column: x => x.NGenderId,
                        principalTable: "NGenders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_NTowns_NTownUser",
                        column: x => x.NTownUser,
                        principalTable: "NTowns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GalleryImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    ModifiedBy = table.Column<Guid>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GalleryImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GalleryImages_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GalleryImages_AspNetUsers_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GalleryImages_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserNCategories",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    NCategoryId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserNCategories", x => new { x.UserId, x.NCategoryId });
                    table.ForeignKey(
                        name: "FK_UserNCategories_NCategories_NCategoryId",
                        column: x => x.NCategoryId,
                        principalTable: "NCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserNCategories_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserNHealthStatuses",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    NHealthStatusId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserNHealthStatuses", x => new { x.UserId, x.NHealthStatusId });
                    table.ForeignKey(
                        name: "FK_UserNHealthStatuses_NHealthStatuses_NHealthStatusId",
                        column: x => x.NHealthStatusId,
                        principalTable: "NHealthStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserNHealthStatuses_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserNJobTypes",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    NJobTypeId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserNJobTypes", x => new { x.UserId, x.NJobTypeId });
                    table.ForeignKey(
                        name: "FK_UserNJobTypes_NJobTypes_NJobTypeId",
                        column: x => x.NJobTypeId,
                        principalTable: "NJobTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserNJobTypes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UsersNSkills",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    NSkillId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersNSkills", x => new { x.UserId, x.NSkillId });
                    table.ForeignKey(
                        name: "FK_UsersNSkills_NSkills_NSkillId",
                        column: x => x.NSkillId,
                        principalTable: "NSkills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsersNSkills_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "NCategories",
                columns: new[] { "Id", "Name", "Position" },
                values: new object[,]
                {
                    { new Guid("9397d4bb-a2dc-4125-902b-df97bb9327e7"), "Морски и Речен транспорт", 23 },
                    { new Guid("105134da-b114-4dea-862e-bd7b5285359d"), "ИТ - Административни дейности и продажби", 16 },
                    { new Guid("f6f5a415-0c2d-4005-9586-ad788c619973"), "Институции, Държавна администрация", 15 },
                    { new Guid("fec96e9f-2fb4-41fb-9258-134002341844"), "Инженери", 14 },
                    { new Guid("89503e87-b3cc-4221-bff6-d57bd2f80c55"), "Изследователска и Развойна дейност (R&D)", 13 },
                    { new Guid("35eb9bae-a587-4040-9ca2-cf429125a7ca"), "Изкуство, Развлечение, Промоции", 12 },
                    { new Guid("560a3abf-0df5-4691-bbd3-0b111a9cb7c8"), "Здравеопазване и фармация", 11 },
                    { new Guid("07647d93-b2c1-46ba-a74e-43958f633617"), "ИТ - Разработка/поддръжка на софтуер", 17 },
                    { new Guid("50770e5e-de9f-474f-8d5a-d533b6d23064"), "Застраховане", 10 },
                    { new Guid("70de3920-b0f4-440c-af86-409c8ffc975a"), "Дизайн, Криейтив, Видео и Анимация", 8 },
                    { new Guid("2f1f6dc1-bf09-47db-ab0f-773965bdce6e"), "Бизнес/Консултантски услуги", 7 },
                    { new Guid("1aaad4a5-bf4c-4b8f-a572-5a7ad85df55b"), "Банки, Кредитиране", 6 },
                    { new Guid("ee78c33d-25a3-42c3-94d5-50711f592b7b"), "Архитектура, Строителство и Градоустройство", 5 },
                    { new Guid("763b1b28-5cb7-4752-af83-f2b3ab9b50d5"), "Административни и офис дейности", 4 },
                    { new Guid("5cc6f7cd-1049-4d1d-971f-859eea95c8f0"), "Автомобили, Автосервизи, Бензиностанции", 3 },
                    { new Guid("1a842a87-390a-4ccc-93c0-c3d11feb8ccf"), "Енергетика и Ютилитис (Ток/Вода/Парно/Газ)", 9 },
                    { new Guid("9c663aeb-41ba-4a6b-8b6c-4efbe022f80e"), "Авиация, Летища и Авиолинии", 2 },
                    { new Guid("84545cad-0636-4460-a39e-9f2a62f54285"), "ИТ - Разработка/поддръжка на хардуер", 18 },
                    { new Guid("aa589150-e846-442a-a81d-845b7b81262a"), "Маркетинг", 20 },
                    { new Guid("8866c643-dfaf-4ecc-ae6f-ecf438c8693d"), "Производство - Химия и Горива", 34 },
                    { new Guid("5a4de6ae-c0c0-4529-97e5-6632d44751ae"), "Производство - Фармация", 33 },
                    { new Guid("70062d3d-13ea-4612-b7d5-4c98eee44b6c"), "Производство - Текстил и Облеклa", 32 },
                    { new Guid("4f82ca00-b5e5-48f3-9f17-3c92bd372745"), "Производство - Металургия и Минно дело", 31 },
                    { new Guid("00a030c6-826d-44b2-9510-40aed333f231"), "Производство - Мебели и Дърводелство", 30 },
                    { new Guid("4e12a0aa-e692-4245-9c23-d9fa242046d2"), "Производство - Електроника, Електротехника, Машиностроене", 29 },
                    { new Guid("62ddab8d-374b-4632-b85f-e1e8a31a9415"), "Контакт центрове (Call Centers)", 19 },
                    { new Guid("2f1ec69a-155b-4b15-8c0e-91747b9f0e21"), "Право, Юридически услуги", 28 },
                    { new Guid("acddb6dc-bb36-449f-b335-0397eab94e8b"), "Организации с нестопанска цел", 26 },
                    { new Guid("bfdda6e6-9552-4e2a-8e9f-ce6df126744e"), "Образование, Курсове, Преводи", 25 },
                    { new Guid("ff63ceee-d5c7-41f8-80d1-fdabe4089302"), "Недвижими имоти", 24 },
                    { new Guid("83167ca0-a659-4886-abb8-2726c5012976"), "Резервации и Туризъм", 37 },
                    { new Guid("79493136-fac5-417f-b5b6-c42f28dd81a9"), "Мениджмънт, Бизнес развитие", 22 },
                    { new Guid("13f7656e-fca3-4462-85c2-cec60b7a13bd"), "Медии, Издателство", 21 },
                    { new Guid("c2b2bfdd-689f-4273-aae7-7c8ed12dd31a"), "Почистване, Услуги за домакинството", 27 },
                    { new Guid("47ea9a93-7897-4355-9786-77970d8fde38"), "Производство - Храни и Напитки", 35 },
                    { new Guid("286a89b4-7e02-4eb2-8ac9-8b61ad52bf0a"), "Всички", 1 },
                    { new Guid("769953f2-e5ee-4565-9b3f-0783500cac4a"), "Ремонтни и Монтажни дейности", 39 },
                    { new Guid("6f8618ef-6916-4686-977f-3f3e96724391"), "Реклама, PR", 38 },
                    { new Guid("ed794ba8-c79c-457f-bf7d-a9fa2cf96ee2"), "Шофьори, Куриери", 53 },
                    { new Guid("2ef63f18-2508-4bc6-96b1-2f806e8a4c12"), "Човешки ресурси", 52 },
                    { new Guid("9fa0afed-17a9-43b1-a9f2-a5d699cdc43c"), "Хотели", 51 },
                    { new Guid("d46931b0-3bb1-4c7e-b766-dae022bae487"), "Физически/Ръчен труд", 50 },
                    { new Guid("716391e1-c9ee-4986-8bcf-a662f9a6e8f9"), "Търговия и продажби", 49 },
                    { new Guid("e4179625-bbaf-489a-bf42-67a6c50ec025"), "Транспорт, Логистика, Спедиция", 48 },
                    { new Guid("632c2da6-a31c-4753-a2be-803f639974ba"), "Производство - Друго", 36 },
                    { new Guid("e33af43f-ef9a-4328-b256-641044bdfdf3"), "Телекомуникации - административни дейности и продажби", 46 },
                    { new Guid("e5bf3d05-1f5b-4aaf-b4fe-107483e56c41"), "Счетоводство, Одит, Финанси", 45 },
                    { new Guid("b0104f7a-ebca-44de-b80d-da055d3df101"), "Спорт, Кинезитерапия", 44 },
                    { new Guid("5c422ffa-6591-4e91-a791-3d6fac033059"), "Сигурност и Охрана", 43 },
                    { new Guid("ae6500fd-6cc5-4447-9054-be879222b3b8"), "Селско и горско стопанство, Рибовъдство", 42 },
                    { new Guid("965345c5-8fcc-4ec7-a573-bbd664657ff3"), "Салони за красота", 41 },
                    { new Guid("11829776-7b9d-46cc-a09c-4922a3685596"), "Телекомуникации - инженери и техници", 47 },
                    { new Guid("d07ee232-5f54-45cf-bb63-665c0694a050"), "Ресторанти, Кетъринг", 40 }
                });

            migrationBuilder.InsertData(
                table: "NCountries",
                columns: new[] { "Id", "Name", "Position" },
                values: new object[] { new Guid("13e63ac5-c912-43c8-a7bf-8bcc1b811b12"), "България", 1 });

            migrationBuilder.InsertData(
                table: "NGenders",
                columns: new[] { "Id", "Name", "Position" },
                values: new object[,]
                {
                    { new Guid("6ec29a78-b51a-4337-b446-1b58f083c4a1"), "Жена", 2 },
                    { new Guid("0dc36894-ea41-4fc3-98a5-b9c091c07350"), "Мъж", 1 },
                    { new Guid("30670687-35a6-42ec-b026-f2e3afce20fe"), "Предпочитам да не отговарям", 3 }
                });

            migrationBuilder.InsertData(
                table: "NHealthStatuses",
                columns: new[] { "Id", "Name", "Position" },
                values: new object[,]
                {
                    { new Guid("8322b682-2148-4cfe-86a7-e0835c624f14"), "Слухови", 1 },
                    { new Guid("7bb42913-a907-4d4a-b292-198d364a02c6"), "Зрителни", 2 }
                });

            migrationBuilder.InsertData(
                table: "NJobTypes",
                columns: new[] { "Id", "Name", "Position" },
                values: new object[,]
                {
                    { new Guid("de516972-59b8-4caa-9729-ed0e8e1becb6"), "Постоянна работа", 2 },
                    { new Guid("d5c6debb-0266-4534-b9e2-584176ba2f89"), "Временна/сезонна работа", 3 },
                    { new Guid("b930c124-7d9d-47cd-9a65-4c1e2d3b433a"), "Стаж", 4 },
                    { new Guid("bed507bf-abd2-40f6-af7e-3ca94abcdfa1"), "Пълно работно време", 5 },
                    { new Guid("c04ed9fb-1afb-47f5-9bf6-a8d62179d84c"), "Непълно работно време", 6 },
                    { new Guid("360fd237-f870-454c-89ef-fb239551938b"), "Подходяща и за студенти", 7 },
                    { new Guid("cb3cf4ab-0f3c-4b8a-83c6-6c185b3adc09"), "Подходяща и за кандидати с малък или без опит", 8 },
                    { new Guid("e3a3eeb1-bf3a-47f6-9bfd-b530dd75e7d1"), "Всички", 1 }
                });

            migrationBuilder.InsertData(
                table: "NSkills",
                columns: new[] { "Id", "Name", "Position" },
                values: new object[,]
                {
                    { new Guid("518f0675-d97d-48c1-874a-c755ef960f2c"), "Плуване", 1 },
                    { new Guid("adf7bbb3-edf8-4593-95ed-2c1ac1ab48c7"), "Четене", 2 },
                    { new Guid("1a96815a-9cb1-4eb8-988f-aaec3d7bd03d"), "Рисуване", 3 }
                });

            migrationBuilder.InsertData(
                table: "NTowns",
                columns: new[] { "Id", "Name", "Position" },
                values: new object[,]
                {
                    { new Guid("eb331abb-37a5-4358-b4c9-1ac5ff2cdacd"), "Пловдив", 1 },
                    { new Guid("9e51e5f1-b33d-4b63-a01e-bfbf09aa2600"), "Варна", 3 },
                    { new Guid("2ebb913e-d3fc-4049-81dd-fb6e100ba5c1"), "София", 2 }
                });

            migrationBuilder.InsertData(
                table: "N_BusinessSectors",
                columns: new[] { "Id", "Name", "Position" },
                values: new object[,]
                {
                    { new Guid("46bc5e3f-ec72-4aab-b7ff-b88c1fd1f54c"), "Образование, научна дейност", 17 },
                    { new Guid("64fac52f-9f6f-4ef2-8a74-80f51a8dfb4a"), "Недвижими имоти", 16 },
                    { new Guid("da305c32-d50c-42b3-86e5-01564241fdda"), "Медии", 15 },
                    { new Guid("1b56bfba-ca75-4800-8ca0-04265fbcc63f"), "Маркетинг/Реклама/ПР", 14 },
                    { new Guid("ab622ef7-dbd7-4d31-9951-6790d62fa1e2"), "Информационни технологии", 13 },
                    { new Guid("b75bdc04-d919-44e2-bd55-7db1f37026b7"), "Интернет/Електронна търговия", 12 },
                    { new Guid("a0798825-6d0c-4ef8-9a85-f1734dc38970"), "Изкуство и забавление", 11 },
                    { new Guid("7c2448cf-d0b4-47c0-9c3b-cc2bb9dac6fe"), "Организации с нестопанска цел", 18 },
                    { new Guid("3a1076d8-85b7-4766-9da2-5cd5444170cd"), "Здравеопазване", 10 },
                    { new Guid("97e69d06-7974-4153-94d1-b8fc07c0d25d"), "Енергетика и ютилитис", 8 },
                    { new Guid("1e5eab77-b8f5-4d84-94ff-a8c1d32c55cc"), "Електроника/електротехника/машиностроене", 7 },
                    { new Guid("994c4796-6e4f-4205-b524-fe20f5ea9b36"), "Държавна администрация", 6 },
                    { new Guid("d92769f9-fc60-4053-80e7-89c2ff3beef6"), "Бизнес, консултантски услуги", 5 },
                    { new Guid("5e5f805e-bfbf-48aa-aca5-e0f2b74e2a87"), "Банки и кредитиране", 4 },
                    { new Guid("6e58cce2-a5ef-4be6-a637-f3c158e03488"), "Архитектура и строителство", 3 },
                    { new Guid("b561410a-37bc-4ee3-ba15-340b089c1125"), "Автомобили, автосервизи, бензиностанции", 2 },
                    { new Guid("3201cf3e-e185-43e6-992b-14e8db4f03cd"), "Застраховане", 9 },
                    { new Guid("0579d8f2-09d6-467c-8b11-ddf87fc23011"), "Друго", 35 },
                    { new Guid("ad98a5eb-5ef6-467f-9066-5006796c5895"), "Авиация, летища, авиолинии", 1 },
                    { new Guid("30b3a2d1-d80e-4f31-a907-260f00f64c55"), "Текстилна индустрия", 25 },
                    { new Guid("8b372efd-97d1-45e0-9a70-5538482ce60b"), "Човешки ресурси", 34 },
                    { new Guid("195cbfec-ad19-4def-b735-5d91b0ace98a"), "Хранителна промишленост", 33 },
                    { new Guid("d0e50cfc-ef31-4e2c-8c79-af30a42eeb27"), "Химия, горива и минно дело", 32 },
                    { new Guid("25848571-785d-41ef-8327-4734cbf3b217"), "Фармация", 31 },
                    { new Guid("8f0ab426-9ed7-4ace-bfc8-8b485747f3cd"), "Охрана", 19 },
                    { new Guid("1a2c82d3-62f8-42d8-ac5b-47b2cf136303"), "Правни и юридически услуги", 20 },
                    { new Guid("28e06c5f-a8a4-4da8-80af-678e35e858a8"), "Производство", 21 },
                    { new Guid("f77f4817-1a78-4671-bc71-36fc6b5af61b"), "Селско стопанство", 22 },
                    { new Guid("53ca96b6-393d-4463-bdb2-02bda224322b"), "Спорт и отдих", 23 },
                    { new Guid("418be391-8002-4963-a332-0b51ae14d3b7"), "Счетоводство/Финанси", 24 },
                    { new Guid("20e34861-e8ca-40dd-9ef0-b25b5b8019ba"), "Услуги", 30 },
                    { new Guid("4bf32082-9f91-4bed-982c-eaea0d841696"), "Телекомуникации", 26 },
                    { new Guid("3174bf3f-673d-4351-8c89-77b3186a5285"), "Транспорт и логистика", 27 },
                    { new Guid("8647988f-bf86-4755-a345-f472567cdeda"), "Туризъм, хотели и ресторанти", 28 },
                    { new Guid("d4169a3e-6281-4e6a-9b31-4844531b7f92"), "Търговия", 29 }
                });

            migrationBuilder.InsertData(
                table: "N_Educations",
                columns: new[] { "Id", "Name", "Position" },
                values: new object[,]
                {
                    { new Guid("60ee7bc3-d424-43a6-a9cd-f7ae111340f3"), "Професионално училище/колеж", 4 },
                    { new Guid("1cd0d768-6d04-4bc6-a9b2-de5b91f02431"), "Начално образование", 1 },
                    { new Guid("326b309b-905d-4293-ab0b-5fa91ddb3e1a"), "Докторска степен", 7 },
                    { new Guid("bf24831a-900a-4fb2-9170-8f7f15197ab2"), "Mагистърска степен", 6 },
                    { new Guid("8ba528e7-de68-4781-be16-84062d52e534"), "Гимназиално образование", 2 },
                    { new Guid("ce72f886-a486-4c18-9a9f-1fe5b339505b"), "Средно образование", 3 },
                    { new Guid("661fc49b-860e-46f4-a69b-de8415028eba"), "Бакалавърска степен", 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_NBusinessSectorId",
                table: "AspNetUsers",
                column: "NBusinessSectorId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_NCountryBusinessnUser",
                table: "AspNetUsers",
                column: "NCountryBusinessnUser");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_NTownBusinessUser",
                table: "AspNetUsers",
                column: "NTownBusinessUser");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_NCountrynUser",
                table: "AspNetUsers",
                column: "NCountrynUser");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_NEducationId",
                table: "AspNetUsers",
                column: "NEducationId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_NGenderId",
                table: "AspNetUsers",
                column: "NGenderId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_NTownUser",
                table: "AspNetUsers",
                column: "NTownUser");

            migrationBuilder.CreateIndex(
                name: "IX_GalleryImages_CreatedBy",
                table: "GalleryImages",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_GalleryImages_ModifiedBy",
                table: "GalleryImages",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_GalleryImages_UserId",
                table: "GalleryImages",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserNCategories_NCategoryId",
                table: "UserNCategories",
                column: "NCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_UserNHealthStatuses_NHealthStatusId",
                table: "UserNHealthStatuses",
                column: "NHealthStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_UserNJobTypes_NJobTypeId",
                table: "UserNJobTypes",
                column: "NJobTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersNSkills_NSkillId",
                table: "UsersNSkills",
                column: "NSkillId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "GalleryImages");

            migrationBuilder.DropTable(
                name: "UserNCategories");

            migrationBuilder.DropTable(
                name: "UserNHealthStatuses");

            migrationBuilder.DropTable(
                name: "UserNJobTypes");

            migrationBuilder.DropTable(
                name: "UsersNSkills");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "NCategories");

            migrationBuilder.DropTable(
                name: "NHealthStatuses");

            migrationBuilder.DropTable(
                name: "NJobTypes");

            migrationBuilder.DropTable(
                name: "NSkills");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "N_BusinessSectors");

            migrationBuilder.DropTable(
                name: "NCountries");

            migrationBuilder.DropTable(
                name: "NTowns");

            migrationBuilder.DropTable(
                name: "N_Educations");

            migrationBuilder.DropTable(
                name: "NGenders");
        }
    }
}
