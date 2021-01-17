namespace JobManagement.Data
{
    using System;
    using System.Collections.Generic;
    using Microsoft.EntityFrameworkCore;
    using Models.Nomenclatures;

    public static class DataSeed
    {
        public static void SeedGender (ModelBuilder builder)
        {
            var genders = new List<NGender>
            {
                new NGender
                {
                    Id = new Guid("0DC36894-EA41-4FC3-98A5-B9C091C07350"),
                    Name = "Мъж",
                    Position = 1
                },
                new NGender
                {
                    Id = new Guid("6EC29A78-B51A-4337-B446-1B58F083C4A1"),
                    Name = "Жена",
                    Position = 2
                },
                new NGender
                {
                    Id = new Guid("30670687-35A6-42EC-B026-F2E3AFCE20FE"),
                    Name = "Предпочитам да не отговарям",
                    Position = 3
                },
            };
            builder.Entity<NGender>().HasData(genders);
        }

        public static void SeedCountry(ModelBuilder builder)
        {
            var countries = new List<NCountry>
            {
                new NCountry
                {
                    Id = new Guid("13E63AC5-C912-43C8-A7BF-8BCC1B811B12"),
                    Name = "България",
                    Position = 1
                }
            };
            builder.Entity<NCountry>().HasData(countries);
        }

         public static void SeedTown(ModelBuilder builder)
        {
            var towns = new List<NTown>
            {
                new NTown
                {
                    Id = new Guid("EB331ABB-37A5-4358-B4C9-1AC5FF2CDACD"),
                    Name = "Пловдив",
                    Position = 1
                },
                new NTown
                {
                    Id = new Guid("2EBB913E-D3FC-4049-81DD-FB6E100BA5C1"),
                    Name = "София",
                    Position = 2
                },
                new NTown
                {
                    Id = new Guid("9E51E5F1-B33D-4B63-A01E-BFBF09AA2600"),
                    Name = "Варна",
                    Position = 3
                }
            };
            builder.Entity<NTown>().HasData(towns);
        }


        public static void SeedHealthStatuses(ModelBuilder builder)
        {
            var healthStatuses = new List<NHealthStatus>
            {
                new NHealthStatus
                {
                    Id = new Guid("8322B682-2148-4CFE-86A7-E0835C624F14"),
                    Name = "Слухови",
                    Position = 1
                },
                new NHealthStatus
                {
                    Id = new Guid("7BB42913-A907-4D4A-B292-198D364A02C6"),
                    Name = "Зрителни",
                    Position = 2
                }
            };
            builder.Entity<NHealthStatus>().HasData(healthStatuses);
        }

        public static void SeedJobTypes(ModelBuilder builder)
        {
            var jobTypes = new List<NJobType>
            {
                new NJobType
                {
                    Id = new Guid("E3A3EEB1-BF3A-47F6-9BFD-B530DD75E7D1"),
                    Name = "Всички",
                    Position = 1
                },
                new NJobType
                {
                    Id = new Guid("DE516972-59B8-4CAA-9729-ED0E8E1BECB6"),
                    Name = "Постоянна работа",
                    Position = 2
                },
                new NJobType
                {
                    Id = new Guid("D5C6DEBB-0266-4534-B9E2-584176BA2F89"),
                    Name = "Временна/сезонна работа",
                    Position = 3
                },
                new NJobType
                {
                    Id = new Guid("B930C124-7D9D-47CD-9A65-4C1E2D3B433A"),
                    Name = "Стаж",
                    Position = 4
                },
                new NJobType
                {
                    Id = new Guid("BED507BF-ABD2-40F6-AF7E-3CA94ABCDFA1"),
                    Name = "Пълно работно време",
                    Position = 5
                },
                new NJobType
                {
                    Id = new Guid("C04ED9FB-1AFB-47F5-9BF6-A8D62179D84C"),
                    Name = "Непълно работно време",
                    Position = 6
                },
                new NJobType
                {
                    Id = new Guid("360FD237-F870-454C-89EF-FB239551938B"),
                    Name = "Подходяща и за студенти",
                    Position = 7
                },
                new NJobType
                {
                    Id = new Guid("CB3CF4AB-0F3C-4B8A-83C6-6C185B3ADC09"),
                    Name = "Подходяща и за кандидати с малък или без опит",
                    Position = 8
                }
            };
            builder.Entity<NJobType>().HasData(jobTypes);
        }

        public static void SeedCategories(ModelBuilder builder)
        {
            var categories = new List<NCategory>
            {
                new NCategory
                {
                    Id = new Guid("286A89B4-7E02-4EB2-8AC9-8B61AD52BF0A"),
                    Name = "Всички",
                    Position = 1
                },
                new NCategory
                {
                    Id = new Guid("9C663AEB-41BA-4A6B-8B6C-4EFBE022F80E"),
                    Name = "Авиация, Летища и Авиолинии",
                    Position = 2
                },
                new NCategory
                {
                    Id = new Guid("5CC6F7CD-1049-4D1D-971F-859EEA95C8F0"),
                    Name = "Автомобили, Автосервизи, Бензиностанции",
                    Position = 3
                },
                new NCategory
                {
                    Id = new Guid("763B1B28-5CB7-4752-AF83-F2B3AB9B50D5"),
                    Name = "Административни и офис дейности",
                    Position = 4
                },
                new NCategory
                {
                    Id = new Guid("EE78C33D-25A3-42C3-94D5-50711F592B7B"),
                    Name = "Архитектура, Строителство и Градоустройство",
                    Position = 5
                },
                new NCategory
                {
                    Id = new Guid("1AAAD4A5-BF4C-4B8F-A572-5A7AD85DF55B"),
                    Name = "Банки, Кредитиране",
                    Position = 6
                },
                new NCategory
                {
                    Id = new Guid("2F1F6DC1-BF09-47DB-AB0F-773965BDCE6E"),
                    Name = "Бизнес/Консултантски услуги",
                    Position = 7
                },
                new NCategory
                {
                    Id = new Guid("70DE3920-B0F4-440C-AF86-409C8FFC975A"),
                    Name = "Дизайн, Криейтив, Видео и Анимация",
                    Position = 8
                },
                new NCategory
                {
                    Id = new Guid("1A842A87-390A-4CCC-93C0-C3D11FEB8CCF"),
                    Name = "Енергетика и Ютилитис (Ток/Вода/Парно/Газ)",
                    Position = 9
                },
                new NCategory
                {
                    Id = new Guid("50770E5E-DE9F-474F-8D5A-D533B6D23064"),
                    Name = "Застраховане",
                    Position = 10
                },
                new NCategory
                {
                    Id = new Guid("560A3ABF-0DF5-4691-BBD3-0B111A9CB7C8"),
                    Name = "Здравеопазване и фармация",
                    Position = 11
                },
                new NCategory
                {
                    Id = new Guid("35EB9BAE-A587-4040-9CA2-CF429125A7CA"),
                    Name = "Изкуство, Развлечение, Промоции",
                    Position = 12
                },
                new NCategory
                {
                    Id = new Guid("89503E87-B3CC-4221-BFF6-D57BD2F80C55"),
                    Name = "Изследователска и Развойна дейност (R&D)",
                    Position = 13
                },
                new NCategory
                {
                    Id = new Guid("FEC96E9F-2FB4-41FB-9258-134002341844"),
                    Name = "Инженери",
                    Position = 14
                },
                new NCategory
                {
                    Id = new Guid("F6F5A415-0C2D-4005-9586-AD788C619973"),
                    Name = "Институции, Държавна администрация",
                    Position = 15
                },
                new NCategory
                {
                    Id = new Guid("105134DA-B114-4DEA-862E-BD7B5285359D"),
                    Name = "ИТ - Административни дейности и продажби",
                    Position = 16
                },
                new NCategory
                {
                    Id = new Guid("07647D93-B2C1-46BA-A74E-43958F633617"),
                    Name = "ИТ - Разработка/поддръжка на софтуер",
                    Position = 17
                },
                new NCategory
                {
                    Id = new Guid("84545CAD-0636-4460-A39E-9F2A62F54285"),
                    Name = "ИТ - Разработка/поддръжка на хардуер",
                    Position = 18
                },
                new NCategory
                {
                    Id = new Guid("62DDAB8D-374B-4632-B85F-E1E8A31A9415"),
                    Name = "Контакт центрове (Call Centers)",
                    Position = 19
                },
                new NCategory
                {
                    Id = new Guid("AA589150-E846-442A-A81D-845B7B81262A"),
                    Name = "Маркетинг",
                    Position = 20
                },
                new NCategory
                {
                    Id = new Guid("13F7656E-FCA3-4462-85C2-CEC60B7A13BD"),
                    Name = "Медии, Издателство",
                    Position = 21
                },
                new NCategory
                {
                    Id = new Guid("79493136-FAC5-417F-B5B6-C42F28DD81A9"),
                    Name = "Мениджмънт, Бизнес развитие",
                    Position = 22
                },
                new NCategory
                {
                    Id = new Guid("9397D4BB-A2DC-4125-902B-DF97BB9327E7"),
                    Name = "Морски и Речен транспорт",
                    Position = 23
                },
                new NCategory
                {
                    Id = new Guid("FF63CEEE-D5C7-41F8-80D1-FDABE4089302"),
                    Name = "Недвижими имоти",
                    Position = 24
                },
                new NCategory
                {
                    Id = new Guid("BFDDA6E6-9552-4E2A-8E9F-CE6DF126744E"),
                    Name = "Образование, Курсове, Преводи",
                    Position = 25
                },
                new NCategory
                {
                    Id = new Guid("ACDDB6DC-BB36-449F-B335-0397EAB94E8B"),
                    Name = "Организации с нестопанска цел",
                    Position = 26
                },
                new NCategory
                {
                    Id = new Guid("C2B2BFDD-689F-4273-AAE7-7C8ED12DD31A"),
                    Name = "Почистване, Услуги за домакинството",
                    Position = 27
                },
                new NCategory
                {
                    Id = new Guid("2F1EC69A-155B-4B15-8C0E-91747B9F0E21"),
                    Name = "Право, Юридически услуги",
                    Position = 28
                },
                new NCategory
                {
                    Id = new Guid("4E12A0AA-E692-4245-9C23-D9FA242046D2"),
                    Name = "Производство - Електроника, Електротехника, Машиностроене",
                    Position = 29
                },
                new NCategory
                {
                    Id = new Guid("00A030C6-826D-44B2-9510-40AED333F231"),
                    Name = "Производство - Мебели и Дърводелство",
                    Position = 30
                },
                new NCategory
                {
                    Id = new Guid("4F82CA00-B5E5-48F3-9F17-3C92BD372745"),
                    Name = "Производство - Металургия и Минно дело",
                    Position = 31
                },
                new NCategory
                {
                    Id = new Guid("70062D3D-13EA-4612-B7D5-4C98EEE44B6C"),
                    Name = "Производство - Текстил и Облеклa",
                    Position = 32
                },
                new NCategory
                {
                    Id = new Guid("5A4DE6AE-C0C0-4529-97E5-6632D44751AE"),
                    Name = "Производство - Фармация",
                    Position = 33
                },
                new NCategory
                {
                    Id = new Guid("8866C643-DFAF-4ECC-AE6F-ECF438C8693D"),
                    Name = "Производство - Химия и Горива",
                    Position = 34
                },
                new NCategory
                {
                    Id = new Guid("47EA9A93-7897-4355-9786-77970D8FDE38"),
                    Name = "Производство - Храни и Напитки",
                    Position = 35
                },
                new NCategory
                {
                    Id = new Guid("632C2DA6-A31C-4753-A2BE-803F639974BA"),
                    Name = "Производство - Друго",
                    Position = 36
                },
                new NCategory
                {
                    Id = new Guid("83167CA0-A659-4886-ABB8-2726C5012976"),
                    Name = "Резервации и Туризъм",
                    Position = 37
                },
                new NCategory
                {
                    Id = new Guid("6F8618EF-6916-4686-977F-3F3E96724391"),
                    Name = "Реклама, PR",
                    Position = 38
                },
                new NCategory
                {
                    Id = new Guid("769953F2-E5EE-4565-9B3F-0783500CAC4A"),
                    Name = "Ремонтни и Монтажни дейности",
                    Position = 39
                },
                new NCategory
                {
                    Id = new Guid("D07EE232-5F54-45CF-BB63-665C0694A050"),
                    Name = "Ресторанти, Кетъринг",
                    Position = 40
                },
                new NCategory
                {
                    Id = new Guid("965345C5-8FCC-4EC7-A573-BBD664657FF3"),
                    Name = "Салони за красота",
                    Position = 41
                },
                new NCategory
                {
                    Id = new Guid("AE6500FD-6CC5-4447-9054-BE879222B3B8"),
                    Name = "Селско и горско стопанство, Рибовъдство",
                    Position = 42
                },
                new NCategory
                {
                    Id = new Guid("5C422FFA-6591-4E91-A791-3D6FAC033059"),
                    Name = "Сигурност и Охрана",
                    Position = 43
                },
                new NCategory
                {
                    Id = new Guid("B0104F7A-EBCA-44DE-B80D-DA055D3DF101"),
                    Name = "Спорт, Кинезитерапия",
                    Position = 44
                },
                new NCategory
                {
                    Id = new Guid("E5BF3D05-1F5B-4AAF-B4FE-107483E56C41"),
                    Name = "Счетоводство, Одит, Финанси",
                    Position = 45
                },
                new NCategory
                {
                    Id = new Guid("E33AF43F-EF9A-4328-B256-641044BDFDF3"),
                    Name = "Телекомуникации - административни дейности и продажби",
                    Position = 46
                },
                new NCategory
                {
                    Id = new Guid("11829776-7B9D-46CC-A09C-4922A3685596"),
                    Name = "Телекомуникации - инженери и техници",
                    Position = 47
                },
                new NCategory
                {
                    Id = new Guid("E4179625-BBAF-489A-BF42-67A6C50EC025"),
                    Name = "Транспорт, Логистика, Спедиция",
                    Position = 48
                },
                new NCategory
                {
                    Id = new Guid("716391E1-C9EE-4986-8BCF-A662F9A6E8F9"),
                    Name = "Търговия и продажби",
                    Position = 49
                },
                new NCategory
                {
                    Id = new Guid("D46931B0-3BB1-4C7E-B766-DAE022BAE487"),
                    Name = "Физически/Ръчен труд",
                    Position = 50
                },
                new NCategory
                {
                    Id = new Guid("9FA0AFED-17A9-43B1-A9F2-A5D699CDC43C"),
                    Name = "Хотели",
                    Position = 51
                },
                new NCategory
                {
                    Id = new Guid("2EF63F18-2508-4BC6-96B1-2F806E8A4C12"),
                    Name = "Човешки ресурси",
                    Position = 52
                },
                new NCategory
                {
                    Id = new Guid("ED794BA8-C79C-457F-BF7D-A9FA2CF96EE2"),
                    Name = "Шофьори, Куриери",
                    Position = 53
                }
            };

            builder.Entity<NCategory>().HasData(categories);


        }


        public static void SeedSkills(ModelBuilder builder)
        {
            var skills = new List<NSkill>
           {
               new NSkill
               {
                   Id = new Guid("518F0675-D97D-48C1-874A-C755EF960F2C"),
                   Name = "Плуване",
                   Position = 1
               },
               new NSkill
               {
                   Id = new Guid("ADF7BBB3-EDF8-4593-95ED-2C1AC1AB48C7"),
                   Name = "Четене",
                   Position = 2
               },
               new NSkill
               {
                   Id = new Guid("1A96815A-9CB1-4EB8-988F-AAEC3D7BD03D"),
                   Name = "Рисуване",
                   Position = 3
               }
           };

            builder.Entity<NSkill>().HasData(skills);


        }

        public static void SeedEducation(ModelBuilder builder)
        {

            var educations = new List<NEducation>
            {
                new NEducation
                {
                    Id = new Guid("1cd0d768-6d04-4bc6-a9b2-de5b91f02431"),
                    Name = "Начално образование",
                    Position = 1
                },
                new NEducation
                {
                    Id = new Guid("8ba528e7-de68-4781-be16-84062d52e534"),
                    Name = "Гимназиално образование",
                    Position = 2
                },
                new NEducation
                {
                    Id = new Guid("ce72f886-a486-4c18-9a9f-1fe5b339505b"),
                    Name = "Средно образование",
                    Position = 3
                },
                new NEducation
                {
                    Id = new Guid("60ee7bc3-d424-43a6-a9cd-f7ae111340f3"),
                    Name = "Професионално училище/колеж",
                    Position = 4
                },
                new NEducation
                {
                    Id = new Guid("661fc49b-860e-46f4-a69b-de8415028eba"),
                    Name = "Бакалавърска степен",
                    Position = 5
                },
                new NEducation
                {
                    Id = new Guid("bf24831a-900a-4fb2-9170-8f7f15197ab2"),
                    Name = "Mагистърска степен",
                    Position = 6
                },
                new NEducation
                {
                    Id = new Guid("326b309b-905d-4293-ab0b-5fa91ddb3e1a"),
                    Name = "Докторска степен",
                    Position = 7
                },
            };

            builder.Entity<NEducation>().HasData(educations);


        }

        public static void SeedBusinessSector(ModelBuilder builder)
        {

            var businessSectors = new List<NBusinessSector>
            {
                new NBusinessSector
                {
                    Id = new Guid("ad98a5eb-5ef6-467f-9066-5006796c5895"),
                    Name = "Авиация, летища, авиолинии",
                    Position = 1
                },
                new NBusinessSector
                {
                    Id = new Guid("b561410a-37bc-4ee3-ba15-340b089c1125"),
                    Name = "Автомобили, автосервизи, бензиностанции",
                    Position = 2
                },
                new NBusinessSector
                {
                    Id = new Guid("6e58cce2-a5ef-4be6-a637-f3c158e03488"),
                    Name = "Архитектура и строителство",
                    Position = 3
                },
                new NBusinessSector
                {
                    Id = new Guid("5e5f805e-bfbf-48aa-aca5-e0f2b74e2a87"),
                    Name = "Банки и кредитиране",
                    Position = 4
                },
                new NBusinessSector
                {
                    Id = new Guid("d92769f9-fc60-4053-80e7-89c2ff3beef6"),
                    Name = "Бизнес, консултантски услуги",
                    Position = 5
                },
                new NBusinessSector
                {
                    Id = new Guid("994c4796-6e4f-4205-b524-fe20f5ea9b36"),
                    Name = "Държавна администрация",
                    Position = 6
                },
                new NBusinessSector
                {
                    Id = new Guid("1e5eab77-b8f5-4d84-94ff-a8c1d32c55cc"),
                    Name = "Електроника/електротехника/машиностроене",
                    Position = 7
                },
                new NBusinessSector
                {
                    Id = new Guid("97e69d06-7974-4153-94d1-b8fc07c0d25d"),
                    Name = "Енергетика и ютилитис",
                    Position = 8
                },
                new NBusinessSector
                {
                    Id = new Guid("3201cf3e-e185-43e6-992b-14e8db4f03cd"),
                    Name = "Застраховане",
                    Position = 9
                },
                new NBusinessSector
                {
                    Id = new Guid("3a1076d8-85b7-4766-9da2-5cd5444170cd"),
                    Name = "Здравеопазване",
                    Position = 10
                },
                new NBusinessSector
                {
                    Id = new Guid("a0798825-6d0c-4ef8-9a85-f1734dc38970"),
                    Name = "Изкуство и забавление",
                    Position = 11
                },
                new NBusinessSector
                {
                    Id = new Guid("b75bdc04-d919-44e2-bd55-7db1f37026b7"),
                    Name = "Интернет/Електронна търговия",
                    Position = 12
                },
                new NBusinessSector
                {
                    Id = new Guid("ab622ef7-dbd7-4d31-9951-6790d62fa1e2"),
                    Name = "Информационни технологии",
                    Position = 13
                },
                new NBusinessSector
                {
                    Id = new Guid("1b56bfba-ca75-4800-8ca0-04265fbcc63f"),
                    Name = "Маркетинг/Реклама/ПР",
                    Position = 14
                },
                new NBusinessSector
                {
                    Id = new Guid("da305c32-d50c-42b3-86e5-01564241fdda"),
                    Name = "Медии",
                    Position = 15
                },
                new NBusinessSector
                {
                    Id = new Guid("64fac52f-9f6f-4ef2-8a74-80f51a8dfb4a"),
                    Name = "Недвижими имоти",
                    Position = 16
                },
                new NBusinessSector
                {
                    Id = new Guid("46bc5e3f-ec72-4aab-b7ff-b88c1fd1f54c"),
                    Name = "Образование, научна дейност",
                    Position = 17
                },
                new NBusinessSector
                {
                    Id = new Guid("7c2448cf-d0b4-47c0-9c3b-cc2bb9dac6fe"),
                    Name = "Организации с нестопанска цел",
                    Position = 18
                },
                new NBusinessSector
                {
                    Id = new Guid("8f0ab426-9ed7-4ace-bfc8-8b485747f3cd"),
                    Name = "Охрана",
                    Position = 19
                },
                new NBusinessSector
                {
                    Id = new Guid("1a2c82d3-62f8-42d8-ac5b-47b2cf136303"),
                    Name = "Правни и юридически услуги",
                    Position = 20
                },
                new NBusinessSector
                {
                    Id = new Guid("28e06c5f-a8a4-4da8-80af-678e35e858a8"),
                    Name = "Производство",
                    Position = 21
                },
                new NBusinessSector
                {
                    Id = new Guid("f77f4817-1a78-4671-bc71-36fc6b5af61b"),
                    Name = "Селско стопанство",
                    Position = 22
                },
                new NBusinessSector
                {
                    Id = new Guid("53ca96b6-393d-4463-bdb2-02bda224322b"),
                    Name = "Спорт и отдих",
                    Position = 23
                },
                new NBusinessSector
                {
                    Id = new Guid("418be391-8002-4963-a332-0b51ae14d3b7"),
                    Name = "Счетоводство/Финанси",
                    Position = 24
                },
                new NBusinessSector
                {
                    Id = new Guid("30b3a2d1-d80e-4f31-a907-260f00f64c55"),
                    Name = "Текстилна индустрия",
                    Position = 25
                },
                new NBusinessSector
                {
                    Id = new Guid("4bf32082-9f91-4bed-982c-eaea0d841696"),
                    Name = "Телекомуникации",
                    Position = 26
                },
                new NBusinessSector
                {
                    Id = new Guid("3174bf3f-673d-4351-8c89-77b3186a5285"),
                    Name = "Транспорт и логистика",
                    Position = 27
                },
                new NBusinessSector
                {
                    Id = new Guid("8647988f-bf86-4755-a345-f472567cdeda"),
                    Name = "Туризъм, хотели и ресторанти",
                    Position = 28
                },
                new NBusinessSector
                {
                    Id = new Guid("d4169a3e-6281-4e6a-9b31-4844531b7f92"),
                    Name = "Търговия",
                    Position = 29
                },
                new NBusinessSector
                {
                    Id = new Guid("20e34861-e8ca-40dd-9ef0-b25b5b8019ba"),
                    Name = "Услуги",
                    Position = 30
                },
                new NBusinessSector
                {
                    Id = new Guid("25848571-785d-41ef-8327-4734cbf3b217"),
                    Name = "Фармация",
                    Position = 31
                },
                new NBusinessSector
                {
                    Id = new Guid("d0e50cfc-ef31-4e2c-8c79-af30a42eeb27"),
                    Name = "Химия, горива и минно дело",
                    Position = 32
                },
                new NBusinessSector
                {
                    Id = new Guid("195cbfec-ad19-4def-b735-5d91b0ace98a"),
                    Name = "Хранителна промишленост",
                    Position = 33
                },
                new NBusinessSector
                {
                    Id = new Guid("8b372efd-97d1-45e0-9a70-5538482ce60b"),
                    Name = "Човешки ресурси",
                    Position = 34
                },
                new NBusinessSector
                {
                    Id = new Guid("0579d8f2-09d6-467c-8b11-ddf87fc23011"),
                    Name = "Друго",
                    Position = 35
                }
            };

            builder.Entity<NBusinessSector>().HasData(businessSectors);


        }
    }
}
