# Buổi 03 – Ngăn xếp (Stack) & Hàng đợi (Queue)

Họ tên: Vũ Đức Anh Tuấn - MSV: 12425055

## Bài đã làm

* **Phần 1:** Bài 1, 2, 3, 4, 5, 6
* **Phần 2:** Bài 4, 5, 6, 7, 8, 9, 10, 11

## Cách chạy

```bash
# Phần 1: Bài tập áp dụng (1 -> 6)
dotnet run --project Buoi03_Stack_Queue/B1
dotnet run --project Buoi03_Stack_Queue/B2
dotnet run --project Buoi03_Stack_Queue/B3
dotnet run --project Buoi03_Stack_Queue/B4
dotnet run --project Buoi03_Stack_Queue/B5
dotnet run --project Buoi03_Stack_Queue/B6

# Phần 2: Bài tập tự thực hành (4 -> 11)
dotnet run --project Buoi03_Stack_Queue/B4CuoiSach
dotnet run --project Buoi03_Stack_Queue/B5CuoiSach
dotnet run --project Buoi03_Stack_Queue/B6CuoiSach
dotnet run --project Buoi03_Stack_Queue/B7CuoiSach
dotnet run --project Buoi03_Stack_Queue/B8CuoiSach
dotnet run --project Buoi03_Stack_Queue/B9CuoiSach
dotnet run --project Buoi03_Stack_Queue/B10CuoiSach
dotnet run --project Buoi03_Stack_Queue/B11CuoiSach
```

## Kết quả chạy
```Text
=== Phần 1 - Bài 1 ===
Nhập biểu thức: {[()]}
Biểu thức hợp lệ

=== Phần 1 - Bài 2 ===
Đang truy cập: google.com
Đang truy cập: youtube.com
Đang truy cập: github.com
Back -> youtube.com
Back -> google.com
Forward -> youtube.com

=== Phần 1 - Bài 3 ===
[CALL] Đẩy vào Stack: Main()
  -> Call Stack: Main()
[CALL] Đẩy vào Stack: TinhTong(5, 3)
  -> Call Stack: TinhTong(5, 3) | Main()
[CALL] Đẩy vào Stack: KiemTra(5)
  -> Call Stack: KiemTra(5) | TinhTong(5, 3) | Main()
[RETURN] Lấy ra: KiemTra(5)
  -> Call Stack: TinhTong(5, 3) | Main()
[RETURN] Lấy ra: TinhTong(5, 3)
  -> Call Stack: Main()
[RETURN] Lấy ra: Main()
  -> Call Stack: Rỗng

=== Phần 1 - Bài 4 ===
Đang in: TaiLieu_01.pdf
Đang in: BaoCao_DSA.docx
Đang in: BangDiem.xlsx

=== Phần 1 - Bài 5 ===
Xử lý gói tin: Packet #1 [SYN]
Xử lý gói tin: Packet #2 [ACK]
Xử lý gói tin: Packet #3 [DATA]

=== Phần 1 - Bài 6 ===
Đang phục vụ: KH01 - Nguyễn Văn A (14:00 - Mở thẻ)
Đang phục vụ: KH02 - Trần Thị B (14:05 - Nộp tiền)
Đang phục vụ: KH03 - Lê Văn C (14:10 - Tư vấn)

=== Phần 2 - Bài 4 ===
=== MÔ PHỎNG LỊCH SỬ TRÌNH DUYỆT ===
1. Truy cập trang mới
2. Quay lại
3. Tiến lên
4. Hiển thị trang hiện tại
0. Thoát
Chọn: 1
Nhập URL: google.com
Đang truy cập: google.com
Chọn: 1
Nhập URL: youtube.com
Đang truy cập: youtube.com
Chọn: 2
Quay lại: google.com
Chọn: 3
Tiến lên: youtube.com

=== Phần 2 - Bài 5 ===
Nhập chuỗi ngoặc: (())()()
Xâu đúng

=== Phần 2 - Bài 6 ===
Chọn: 1
Nhập tên tài liệu: BaoCao_Buoi03.pdf
Chọn: 2
Đang in: BaoCao_Buoi03.pdf

=== Phần 2 - Bài 7 ===
Chọn: 1
Nhập gói dữ liệu: Data_Frame_01
Chọn: 2
Đã nhận: Data_Frame_01

=== Phần 2 - Bài 8 ===
Chọn: 1
Nhập tên/STT khách hàng: KH01 - Vũ Đức Anh Tuấn
Chọn: 2
Đang phục vụ: KH01 - Vũ Đức Anh Tuấn

=== Phần 2 - Bài 9 ===
Nhập biểu thức hậu tố (VD: 3 4 2 * +): 3 4 2 * +
Giá trị biểu thức: 11

=== Phần 2 - Bài 10 ===
Nhập biểu thức trung tố: (3 + 5) * [2 - {4 / 2}]
Biểu thức hợp lệ

=== Phần 2 - Bài 11 ===
Nhập biểu thức trung tố (VD: 3 + 5 * (2 - 4)): 3 + 5 * (2 - 4)
Biểu thức hậu tố: 3 5 2 4 - * +
Kết quả tính toán: -7
```