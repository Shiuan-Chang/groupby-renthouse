using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groupby_renthouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var properties = new List<RentalProperty>
            {
                new RentalProperty { Location = "大安區", Type = "整層住家", Rent = 15000, Layout = 2, roomNums = 2, floor = 2,IsNew = true, NearMRT = true, PetAllowed = false, HasParking = true, HasElevator = true, HasBalcony = true, ShortTermRental = false },
                new RentalProperty { Location = "大安區", Type = "分租套房", Rent = 8000, Layout = 1, roomNums = 3,floor = 1, IsNew = false, NearMRT = true, PetAllowed = true, HasParking = false, HasElevator = true, HasBalcony = false, ShortTermRental = true },
                new RentalProperty { Location = "信義區", Type = "獨立套房", Rent = 20000, Layout = 2, roomNums = 2,floor = 3,IsNew = true, NearMRT = false, PetAllowed = false, HasParking = true, HasElevator = false, HasBalcony = true, ShortTermRental = false },
                new RentalProperty { Location = "信義區", Type = "雅房", Rent = 6000, Layout = 1, roomNums = 4,floor = 2,IsNew = false, NearMRT = false, PetAllowed = false, HasParking = false, HasElevator = false, HasBalcony = false, ShortTermRental = true },
                new RentalProperty { Location = "中正區", Type = "整層住家", Rent = 25000, Layout = 3, roomNums = 3, floor = 2,IsNew = true, NearMRT = true, PetAllowed = true, HasParking = true, HasElevator = true, HasBalcony = true, ShortTermRental = false },
                new RentalProperty { Location = "內湖區", Type = "分租套房", Rent = 9000, Layout = 1, roomNums = 2,floor = 4,IsNew = false, NearMRT = true, PetAllowed = false, HasParking = false, HasElevator = false, HasBalcony = false, ShortTermRental = false },
                new RentalProperty { Location = "士林區", Type = "獨立套房", Rent = 12000, Layout = 2, roomNums = 4,floor = 2,IsNew = false, NearMRT = true, PetAllowed = true, HasParking = false, HasElevator = true, HasBalcony = true, ShortTermRental = false },
                new RentalProperty { Location = "士林區", Type = "車位", Rent = 3000, Layout = 0, roomNums = 1,floor = 1, IsNew = false, NearMRT = false, PetAllowed = false, HasParking = true, HasElevator = false, HasBalcony = false, ShortTermRental = false },
                new RentalProperty { Location = "文山區", Type = "雅房", Rent = 7000, Layout = 1, roomNums = 2,floor = 2, IsNew = false, NearMRT = true, PetAllowed = true, HasParking = false, HasElevator = false, HasBalcony = false, ShortTermRental = true },
                new RentalProperty { Location = "松山區", Type = "整層住家", Rent = 18000, Layout = 2, roomNums = 2,floor = 1,IsNew = true, NearMRT = false, PetAllowed = false, HasParking = true, HasElevator = true, HasBalcony = true, ShortTermRental = false },
                new RentalProperty { Location = "萬華區", Type = "分租套房", Rent = 8500, Layout = 1, roomNums = 1,floor = 2,IsNew = false, NearMRT = true, PetAllowed = false, HasParking = false, HasElevator = true, HasBalcony = false, ShortTermRental = true },
                new RentalProperty { Location = "中山區", Type = "獨立套房", Rent = 13000, Layout = 2, roomNums = 5,floor = 3,IsNew = false, NearMRT = true, PetAllowed = false, HasParking = true, HasElevator = true, HasBalcony = true, ShortTermRental = false },
                new RentalProperty { Location = "北投區", Type = "雅房", Rent = 5000, Layout = 1,roomNums = 3, floor = 2, IsNew = false, NearMRT = false, PetAllowed = false, HasParking = false, HasElevator = false, HasBalcony = false, ShortTermRental = true },
                new RentalProperty { Location = "中正區", Type = "整層住家", Rent = 22000, Layout = 3, roomNums = 6,floor = 4,IsNew = true, NearMRT = true, PetAllowed = true, HasParking = true, HasElevator = true, HasBalcony = true, ShortTermRental = false },
                new RentalProperty { Location = "大同區", Type = "車位", Rent = 4000, Layout = 0, roomNums = 0,floor = 1,IsNew = false, NearMRT = false, PetAllowed = false, HasParking = true, HasElevator = false, HasBalcony = false, ShortTermRental = false },
                new RentalProperty { Location = "大安區", Type = "雅房", Rent = 7500, Layout = 1, roomNums = 2,floor = 2, IsNew = false, NearMRT = true, PetAllowed = true, HasParking = false, HasElevator = false, HasBalcony = false, ShortTermRental = true },
                new RentalProperty { Location = "信義區", Type = "整層住家", Rent = 35000, Layout = 4, roomNums = 8,floor = 2,IsNew = true, NearMRT = true, PetAllowed = false, HasParking = true, HasElevator = true, HasBalcony = true, ShortTermRental = false },
                new RentalProperty { Location = "內湖區", Type = "分租套房", Rent = 10000, Layout = 2, roomNums = 2,floor = 2, IsNew = false, NearMRT = false, PetAllowed = true, HasParking = false, HasElevator = true, HasBalcony = false, ShortTermRental = true },
                new RentalProperty { Location = "士林區", Type = "獨立套房", Rent = 16000, Layout = 3,roomNums = 3, IsNew = true, NearMRT = true, PetAllowed = false, HasParking = true, HasElevator = true, HasBalcony = true, ShortTermRental = false },
                new RentalProperty { Location = "文山區", Type = "車位", Rent = 5000, Layout = 0,roomNums = 1, floor = 1,IsNew = false, NearMRT = false, PetAllowed = false, HasParking = true, HasElevator = false, HasBalcony = false, ShortTermRental = false }
            };


            //題目 1：基礎篩選與分組
            //篩選所有允許「養寵物」(PetAllowed)的租屋物件，並根據 Location 進行分組，選出每個地區的租屋類型(Type)。

            //var Datas1 = properties.Where(x => x.PetAllowed == true).GroupBy(x => new { x.Location,x.Type }).Select(x => new
            //{
            //    Location = x.Key.Location,
            //    Type = x.Key.Type,
            //}).OrderBy(x=>x.Location).ToList();

            //foreach (var data in Datas1)
            //{
            //    Console.WriteLine($"{data.Location}-{data.Type}");
            //}



            //題目 2：租金篩選與分組統計
            //篩選租金(Rent) 在 10,000 元以上的物件，根據 Type 分組，計算每種類型的物件數量(Count)。

            //var Datas2 = properties.Where(x=> x.Rent >= 10000).GroupBy(x => new { x.Type }).Select(x=>new
            //{
            //    Type = x.Key,
            //    Count = x.Count(),
            //}).ToList();

            //foreach (var data in Datas2) 
            //{
            //    Console.WriteLine($"{data.Type}" + ":" + $"{data.Count}");

            //}


            //題目 3：特色篩選與分組
            //找出靠近捷運(NearMRT) 且具有「電梯」(HasElevator)的物件，根據 Location 分組，選出每個地區的平均租金。

            //var Datas3 = properties.Where(x => x.HasElevator == true && x.NearMRT == true).GroupBy(x => new { x.Location }).Select(x => new
            //{
            //    Location = x.Key,
            //    averageRent = x.Average(y=>y.Rent),
            //}).ToList();

            //foreach (var data in Datas3)
            //{
            //    Console.WriteLine($"{data.Location}" + ":" + $"{data.averageRent}");
            //}

            //題目 4：房間數篩選與分組
            //篩選房間數(Layout) 大於 1 的租屋物件，並根據 Type 分組，計算每種類型中房間數的總和。


            //var Datas4 = properties.Where(x=> x.Layout > 1).GroupBy(x => new { x.Type }).Select(x=> new 
            //{
            //    Type = x.Key,
            //    Count = x.Count(),
            //}).ToList();

            //foreach(var data in Datas4)
            //{
            //    Console.WriteLine($"{data.Type}" + ":" + $"{data.Count}");
            //}



            //題目 5：新上架物件統計
            //篩選「新上架」(IsNew)的租屋物件，根據 Location 分組，選出每個地區的新上架物件的最高租金。


            //var Datas5 = properties.Where(x => x.IsNew == true).GroupBy(x => new { x.Location }).Select(x=> new
            //{
            //    Type = x.Key,
            //    HighestRent = x.Max(y => y.Rent),
            //}).ToList();

            //foreach (var data in Datas5) 
            //{
            //    Console.WriteLine($"{data.Type}" + ":" + $"{data.HighestRent}");
            //}



            //題目 6：分組後條件篩選
            //篩選具有「陽台」(HasBalcony)的租屋物件，根據 Location 分組，並僅保留每個地區中房間數(Layout) 大於 2 的物件，計算其平均租金。

            //var Datas6 = properties.Where(x => x.HasBalcony == true).GroupBy(x => new { x.Location }).Select(x => new
            //{
            //    Location = x.Key,
            //    AverageRent = x.Where(y => y.Layout > 2).Select(y => y.Rent).DefaultIfEmpty(0).Average(),
            //}).ToList();

            //foreach (var data in Datas6)
            //{
            //    Console.WriteLine($"{data.Location}" + ":" + $"{data.AverageRent}");
            //}


            //題目 7：綜合篩選與分組統計
            //找出租金(Rent) 在 20,000 元以上，且允許「短期租賃」(ShortTermRental)的物件，根據 Type 分組，計算每種類型中符合條件的物件數量與平均房間數(Layout)。


            //var Datas7 = properties.Where(x => x.Rent >20000 && x.ShortTermRental == true).GroupBy(x => new {x.Type}).Select(x => new
            //{
            //    Type = x.Key,
            //    Count = x.Count(),
            //    Average = x.Select(y=>y.Layout).DefaultIfEmpty(0).Average(),   

            //}).ToArray();

            //foreach (var data in Datas7) 
            //{
            //    Console.WriteLine($"{data.Type}" + ":" + $"{data.Count}" + $"{data.Average}");
            //}


            //題目 8：多條件篩選與分組
            //找出「整層住家」且位於「內湖區」或「信義區」的租屋物件，根據 Location 分組，計算每個地區中允許「養寵物」的物件比例。


            //var Datas8 = properties.Where(x => x.Type == "整層住家" && (x.Location == "內湖區" || x.Location == "信義區")).GroupBy(x => new { x.Location }).Select(x => new
            //{
            //    Location = x.Key.Location,
            //    PetRatio = x.Count(y => y.PetAllowed) / (double)x.Count()
            //}).ToArray();

            //foreach (var data in Datas8)
            //{
            //    Console.WriteLine($"{data.Location} PetRatio: {data.PetRatio:P2}");
            //}


            //題目 9：複合分組與排序
            //篩選具有「車位」(HasParking)且租金(Rent) 在 15,000 元以上的物件，根據 Type 和 Location 進行二級分組，選出每組中的最低租金物件，並按地區名稱進行排序。

            //var Datas9 = properties.Where(x=> x.HasParking == true && x.Rent > 15000).GroupBy(x=> new { x.Location, x.Type }).Select(x=>new
            //{
            //    x.Key.Location,
            //    x.Key.Type,
            //    MinRentProperty = x.OrderBy(y => y.Rent).First()
            //    }).OrderBy(x=>x.Location).ToList();

            //foreach (var data in Datas9)
            //{
            //    Console.WriteLine($"Location: {data.Location}, Type: {data.Type}, Min Rent: {data.MinRentProperty.Rent}");
            //}

            //題目 10：高階綜合查詢
            //找出所有符合以下條件的租屋物件：
            //位於「大安區」、「松山區」或「內湖區」
            //租金(Rent) 超過 25,000 元
            //必須具備「電梯」(HasElevator)和「陽台」(HasBalcony)
            //根據 Location 分組，計算每個地區中符合條件的物件總數，並選出租金最高的物件，顯示其 Location、Type 和 Rent。


            //var Datas10 = properties.Where(x => x.Rent > 25000 && (x.Location == "大安區" || x.Location == "松山區" || x.Location == "內湖區") && x.HasElevator && x.HasBalcony)
            //.GroupBy(x => x.Location)
            //.Select(x => new
            //{
            //    Location = x.Key,
            //    Count = x.Count(),
            //    HighestRent = x.OrderByDescending(y => y.Rent).First()
            //}).ToList();

            //foreach (var data in Datas10)
            //{
            //    Console.WriteLine($"Location: {data.Location}, Highest Rent Type: {data.HighestRent.Type}, Rent: {data.HighestRent.Rent}");
            //}



            //題目 1
            //問題：篩選租金在 10000 到 30000 之間，並且允許養寵物的房屋。請依照「位置」和「房間數」分組，統計每組資料的平均租金是多少。

            //var Datas11 = properties.Where(x=> x.Rent >= 10000 && x.Rent <= 300000 && x.PetAllowed).GroupBy(x=> new { x.Location, x.roomNums }).Select(x => new
            //{
            //    Group = x.Key,
            //    AverageRent = x.Average(y=> y.Rent),
            //}).OrderBy(x => x.Group.roomNums).ToList();

            //foreach(var data in Datas11) 
            //{
            //    Console.WriteLine($"Location: {data.Group}, Highest Rent Type: {data.AverageRent}");
            //}



            //題目 2
            //問題：找出每個「位置」中房租平均在 15000 以上且有陽台的「整層住家」，並依「樓層數」分組，計算每組的平均房租。

            //var Datas12 = properties.Where(x=>x.HasBalcony &&x.Type == "整層住家").GroupBy(x=> new { x.Location }).Where(y=>y.Average(x=>x.Rent) > 15000)
            //    .SelectMany(y=>y.GroupBy(x=>x.Layout).Select(subGroup => new
            //    {
            //        Location = y.Key,      
            //        Layout = subGroup.Key,    
            //        AverageRent = subGroup.Average(property => property.Rent) 
            //    })).ToList();

            //foreach (var data in Datas12) 
            //{
            //    Console.WriteLine($"Location: {data.Location},Layout: {data.Layout}, Average Rent: {data.AverageRent}");
            //}


            //題目 3
            //問題：統計各個「位置」中不同「類型」的房源平均房間數（Rooms）。只包含房租超過 10000 且位於 1 樓以上的資料。

            //var Datas13 = properties.Where(x=>x.Rent > 10000 && x.floor > 1).GroupBy(x=>new { x.Location })
            //    .Select(locationGroup => new
            //    {
            //        Location = locationGroup.Key,
            //        Averages = locationGroup
            //        .GroupBy(y => y.Type) 
            //        .Select(typeGroup => new
            //        {
            //            Type = typeGroup.Key,
            //            AverageRooms = typeGroup.Average(y => y.roomNums) 
            //    })}).ToList();

            //foreach (var data in Datas13)
            //{
            //    Console.WriteLine($"Location: {data.Location}");

            //    foreach (var avg in data.Averages)
            //    {
            //        Console.WriteLine($"  Type: {avg.Type}, Average Rooms: {avg.AverageRooms}");
            //    }
            //}


            //題目 4
            //問題：找出所有不允許養寵物且有陽台的房屋，並根據「房間數」和「樓層數」分組，計算每組的最高租金。

            //var Datas14 = properties.Where(x=>x.PetAllowed == false && x.HasBalcony).GroupBy(x=>new {x.roomNums, x.Layout}).Select(x=>new
            //{
            //    group = x.Key,
            //    MaxRent = x.Max(p=>p.Rent)
            //}).ToList();

            //foreach (var data in Datas14)
            //{
            //    Console.WriteLine($"房間數: {data.group.roomNums}, 樓層: {data.group.Layout}, 最高租金: {data.MaxRent}");
            //}

            //題目 5
            //問題：找出每個「位置」中「樓層數」最高的「整層住家」類型，並顯示房屋的租金、房間數及是否有陽台。

            //var Datas15 = properties.Where(x => x.Type == "整層住家").GroupBy(x => x.Location)
            //    .Select(group => group.OrderByDescending(x => x.floor).FirstOrDefault())
            //    .Select(x => new
            //    {
            //      Location = x.Location,
            //      Rent = x.Rent,
            //      Floor = x.floor,
            //      RoomNums = x.roomNums, 
            //      HasBalcony = x.HasBalcony 
            //     }).ToList();

            //foreach (var data in Datas15)
            //{
            //    Console.WriteLine($"位置: {data.Location}, 租金: {data.Rent},樓層: {data.Floor}, 房間數: {data.RoomNums}, 是否有陽台: {data.HasBalcony}");
            //}

            //題目 6
            //問題: 找出每個位置地區中，不同的類型，能否養寵物他們的租金範圍都在多少~多少之間(列出min~max)
            //並且由房間數最高的依序排序 並顯示能否養寵物

            var Datas16 = properties
            .GroupBy(x => new { x.Location, x.Type }) 
            .Select(group => new
            {
              Location = group.Key.Location,
              Type = group.Key.Type,
              CanHavePet = group.Any(x => x.PetAllowed), 
              MinRent = group.Min(x => x.Rent), 
              MaxRent = group.Max(x => x.Rent), 
              MaxRoomNums = group.Max(x => x.roomNums) 
            }).OrderByDescending(x => x.MaxRoomNums).ToList();

            foreach (var data in Datas16)
            {
                Console.WriteLine($"位置: {data.Location}, 類型: {data.Type}, 可養寵物: {data.CanHavePet}, 租金範圍: {data.MinRent}~{data.MaxRent}, 房間數最高: {data.MaxRoomNums}");
            }
            Console.ReadLine();
        }
    }
}
