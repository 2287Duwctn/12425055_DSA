# Buổi 02 – Danh sách

Họ tên: Vũ Đức Anh Tuấn - MSV: 12425055

## Bài đã làm

Bài 1, 2, 3, 4, 5

## Cách chạy

```bash
dotnet run --project Buoi02_DanhSach/B1
dotnet run --project Buoi02_DanhSach/B2
dotnet run --project Buoi02_DanhSach/B3
dotnet run --project Buoi02_DanhSach/B4
dotnet run --project Buoi02_DanhSach/B5
```
--- Bài 1 ---
Danh sách sau khi chèn 2 vào vị trí 1:
1 2 3

--- Bài 2 ---
Nhập số lượng nhân viên n: 2

Nhập thông tin nhân viên thứ 1:
Mã NV: NV01
Họ tên: Nguyễn Văn A
Năm sinh: 2000
Phòng ban: Kế toán
Lương cơ bản: 5000000
Thưởng: 1500000

Nhập thông tin nhân viên thứ 2:
Mã NV: NV02
Họ tên: Trần Thị B
Năm sinh: 2001
Phòng ban: Nhân sự
Lương cơ bản: 4500000
Thưởng: 1000000

Tổng thực lĩnh tháng : 12000000
Lương cơ bản thấp nhất: 4500000
Danh sách nhân viên có lương cơ bản thấp nhất:
- Mã NV: NV02, Họ tên: Trần Thị B, Năm sinh: 2001, Phòng ban: Nhân sự, Lương CB: 4500000, Thưởng: 1000000
Số lượng nhân viên có thưởng >= 1.200.000: 1

Danh sách nhân viên sau khi sắp xếp theo phòng ban và mã NV:
- Mã NV: NV01, Họ tên: Nguyễn Văn A, Năm sinh: 2000, Phòng ban: Kế toán, Lương CB: 5000000, Thưởng: 1500000
- Mã NV: NV02, Họ tên: Trần Thị B, Năm sinh: 2001, Phòng ban: Nhân sự, Lương CB: 4500000, Thưởng: 1000000

Danh sách nhân viên sau khi tăng lương cơ bản lên 5%:
- Mã NV: NV01, Họ tên: Nguyễn Văn A, Năm sinh: 2000, Phòng ban: Kế toán, Lương CB mới: 5250000, Thưởng: 1500000, Thực lĩnh mới: 6750000
- Mã NV: NV02, Họ tên: Trần Thị B, Năm sinh: 2001, Phòng ban: Nhân sự, Lương CB mới: 4725000, Thưởng: 1000000, Thực lĩnh mới: 5725000

--- Bài 3 ---
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

--- Bài 4 ---
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

--- Bài 5 ---
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