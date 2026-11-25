# Buổi 02 – Danh sách

Họ tên: Vũ Đức Anh Tuấn - MSV: 12425055

## Bài đã làm

Bài 1, 2, 3, 4, 5, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18

## Cách chạy

```bash
dotnet run --project Buoi02_DanhSach/B1
dotnet run --project Buoi02_DanhSach/B2
dotnet run --project Buoi02_DanhSach/B3
dotnet run --project Buoi02_DanhSach/B4
dotnet run --project Buoi02_DanhSach/B5
dotnet run --project Buoi02_DanhSach/B7
dotnet run --project Buoi02_DanhSach/B8
dotnet run --project Buoi02_DanhSach/B9
dotnet run --project Buoi02_DanhSach/B10
dotnet run --project Buoi02_DanhSach/B11
dotnet run --project Buoi02_DanhSach/B12
dotnet run --project Buoi02_DanhSach/B13
dotnet run --project Buoi02_DanhSach/B14
dotnet run --project Buoi02_DanhSach/B15
dotnet run --project Buoi02_DanhSach/B16
dotnet run --project Buoi02_DanhSach/B17
dotnet run --project Buoi02_DanhSach/B18
```

## Kết quả chạy
```Text
--- Bài 1 ---
Danh sách sau khi chèn 2 vào vị trí 1:
1 2 3

=== Bài 2 ===
Nhập số lượng nhân viên n: 2

Nhập thông tin nhân viên thứ 1:
Mã NV: NV01
Họ tên: Vũ Đức Anh Tuấn
Năm sinh: 2007
Phòng ban: Kế toán
Lương cơ bản: 5000000
Thưởng: 1500000

Nhập thông tin nhân viên thứ 2:
Mã NV: NV02
Họ tên: Đào Thị Hà Trang
Năm sinh: 2007
Phòng ban: Nhân sự
Lương cơ bản: 4500000
Thưởng: 1000000

Tổng thực lĩnh tháng : 12000000
Lương cơ bản thấp nhất: 4500000
Danh sách nhân viên có lương cơ bản thấp nhất:
- Mã NV: NV02, Họ tên: Đào Thị Hà Trang, Năm sinh: 2007, Phòng ban: Nhân sự, Lương CB: 4500000, Thưởng: 1000000
Số lượng nhân viên có thưởng >= 1.200.000: 1

Danh sách nhân viên sau khi sắp xếp theo phòng ban và mã NV:
- Mã NV: NV01, Họ tên: Vũ Đức Anh Tuấn, Năm sinh: 2007, Phòng ban: Kế toán, Lương CB: 5000000, Thưởng: 1500000
- Mã NV: NV02, Họ tên: Đào Thị Hà Trang, Năm sinh: 2007, Phòng ban: Nhân sự, Lương CB: 4500000, Thưởng: 1000000

Danh sách nhân viên sau khi tăng lương cơ bản lên 5%:
- Mã NV: NV01, Họ tên: Vũ Đức Anh Tuấn, Năm sinh: 2007, Phòng ban: Kế toán, Lương CB mới: 5250000, Thưởng: 1500000, Thực lĩnh mới: 6750000
- Mã NV: NV02, Họ tên: Đào Thị Hà Trang, Năm sinh: 2007, Phòng ban: Nhân sự, Lương CB mới: 4725000, Thưởng: 1000000, Thực lĩnh mới: 5725000

=== Bài 3 ===
Nhập cấp ma trận vuông n (0 < n < 100): 2
a[0,0] = 1
a[0,1] = 2
a[1,0] = 3
a[1,1] = 4

Ma trận vừa nhập:
     1     2
     3     4

a. Tổng các phần tử ma trận: 10
b. Giá trị dương nhỏ nhất: 1
c. Tổng các phần tử trên đường chéo phụ: 5
d. Đường chéo chính tăng dần: True

=== Bài 4 ===
Nhập số lượng phần tử n: 4
Nhập phần tử thứ 1 (số nguyên dương): 5
Nhập phần tử thứ 2 (số nguyên dương): 2
Nhập phần tử thứ 3 (số nguyên dương): 8
Nhập phần tử thứ 4 (số nguyên dương): 2

Danh sách vừa nhập:
5 -> 2 -> 8 -> 2 -> null

Nhập giá trị x cần đếm: 2
a. Số lượng phần tử bằng 2: 2
b. Phần tử dương nhỏ nhất: 2

c. Nhập giá trị x cần xóa (xuất hiện đầu tiên): 2
Danh sách sau khi xóa:
5 -> 8 -> 2 -> null

=== Bài 5 ===
Nhập số lượng phần tử n: 5
Nhập phần tử thứ 1: -3
Nhập phần tử thứ 2: 0
Nhập phần tử thứ 3: 2
Nhập phần tử thứ 4: 7
Nhập phần tử thứ 5: 2

a. Phần tử lớn nhất: 7
b. Tổng các phần tử: 8
c. Số lượng số nguyên tố: 3
d. Số âm: 1 | Số dương: 3 | Số bằng 0: 1

Nhập giá trị x cần đếm: 2
e. Số lượng phần tử bằng 2: 2
f. Phần tử dương nhỏ nhất: 2

=== Bài 7 ===
Nhập số ngày n: 4
Nhiệt độ ngày 1: 28.5
Nhiệt độ ngày 2: 31.0
Nhiệt độ ngày 3: 26.0
Nhiệt độ ngày 4: 29.5
Ngày nóng nhất: Ngày 2 (31°C)
Ngày lạnh nhất: Ngày 3 (26°C)
Nhiệt độ trung bình: 28.75°C

=== Bài 8 ===
Nhập chuỗi văn bản: Hoc C# rat vui, C# rat hay!

Thống kê tần suất từ:
c#: 2
rat: 2
hoc: 1
vui: 1
hay: 1

=== Bài 9 ===
Nhập số lượng phần tử: 5
arr[0] = 2
arr[1] = 4
arr[2] = 6
arr[3] = 7
arr[4] = 28
Số nguyên tố: 2, 7
Số chẵn: 2, 4, 6, 28
Số hoàn hảo: 6, 28

=== Bài 10 ===
Nhập số hàng m: 3
Nhập số cột n: 3
matrix[0,0] = 1
matrix[0,1] = 2
matrix[0,2] = 3
matrix[1,0] = 4
matrix[1,1] = 5
matrix[1,2] = 6
matrix[2,0] = 7
matrix[2,1] = 8
matrix[2,2] = 9
Thứ tự xoắn ốc: 1 2 3 6 9 8 7 4 5

=== Bài 11 ===
Nhập cấp của ma trận vuông n: 2
matrix[0,0] = 1
matrix[0,1] = 0
matrix[1,0] = 0
matrix[1,1] = 1
Là ma trận đơn vị: Có
Là ma trận đối xứng: Có

=== Bài 12 ===
0 1 * 1 0
1 3 2 2 0
* 2 * 1 0
1 2 2 2 1
0 0 1 * 1

=== Bài 13 ===
Ban đầu: 1 -> 2 -> 3 -> 4 -> null
Đảo ngược: 4 -> 3 -> 2 -> 1 -> null

=== Bài 14 ===
1 -> 2 -> 3 -> 4 -> 5 -> 6 -> null

=== Bài 15 ===
Có chu trình không? True

=== Bài 16 ===
Truy cập: youtube.com
Truy cập: github.com
Back -> youtube.com
Back -> google.com
Forward -> youtube.com

=== Bài 17 ===
Đang phát: Bài 1 - Lạc Trôi
Đang phát: Bài 2 - Nơi Này Có Anh
Đã xóa: Bài 2 - Nơi Này Có Anh
Đang phát: Bài 3 - Cắt Đôi Nỗi Sầu

=== Bài 18 ===
Đơn [DH01]: Đang giao
Đơn [DH02]: Chờ xử lý
<<<<<<< HEAD
```
=======
```
>>>>>>> 1f05a63 (Buoi03: stack queue)
