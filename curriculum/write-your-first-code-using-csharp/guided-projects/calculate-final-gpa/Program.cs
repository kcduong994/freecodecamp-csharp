// ============================================================================
// GUIDED PROJECT: CALCULATE FINAL GPA
// ============================================================================
// Chương trình này tính GPA cuối cùng của một sinh viên dựa trên:
//
// 1. Điểm số của từng môn học.
// 2. Số tín chỉ (credit hours) của từng môn học.
// 3. Tổng số điểm tích lũy có trọng số (grade points).
//
// Công thức:
//
// Grade points của một môn = Điểm môn học × Số tín chỉ
//
// GPA = Tổng grade points / Tổng số tín chỉ
//
// Ví dụ:
// English 101 có điểm 4 và 3 tín chỉ.
// Grade points của English 101 = 4 × 3 = 12.
// ============================================================================


// ============================================================================
// BƯỚC 1: LƯU THÔNG TIN SINH VIÊN
// ============================================================================

// Dùng kiểu string vì tên sinh viên là dữ liệu văn bản.
string studentName = "Sophia Johnson";


// ============================================================================
// BƯỚC 2: LƯU TÊN CÁC MÔN HỌC
// ============================================================================

// Mỗi môn học được lưu trong một biến string riêng.
//
// Ở trình độ hiện tại, bài học chưa sử dụng array, list hoặc class,
// nên chúng ta lưu từng môn học bằng từng biến riêng biệt.
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";


// ============================================================================
// BƯỚC 3: LƯU SỐ TÍN CHỈ CỦA TỪNG MÔN
// ============================================================================

// Credit hour có giá trị là số nguyên, ví dụ 3 hoặc 4,
// nên sử dụng kiểu int.
//
// Số tín chỉ càng lớn thì môn học đó càng có trọng số lớn hơn
// trong kết quả GPA cuối cùng.
int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;


// ============================================================================
// BƯỚC 4: XÁC ĐỊNH GIÁ TRỊ SỐ CỦA ĐIỂM CHỮ
// ============================================================================

// Trong hệ GPA 4.0 được sử dụng trong bài:
//
// A = 4
// B = 3
//
// Bài toán hiện tại chỉ sử dụng điểm A và B,
// vì vậy chúng ta mới cần khai báo hai giá trị này.
int gradeA = 4;
int gradeB = 3;


// ============================================================================
// BƯỚC 5: GÁN ĐIỂM CHO TỪNG MÔN
// ============================================================================

// Thay vì trực tiếp viết:
//
// int course1Grade = 4;
//
// chúng ta gán bằng biến gradeA hoặc gradeB.
//
// Cách này giúp ý nghĩa của mã rõ ràng hơn:
// course1Grade là điểm A, thay vì chỉ nhìn thấy một con số 4.
//
// Nếu sau này quy tắc tính điểm thay đổi,
// ta chỉ cần thay đổi gradeA hoặc gradeB tại một vị trí.
int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;


// ============================================================================
// BƯỚC 6: TÍNH TỔNG SỐ TÍN CHỈ
// ============================================================================

// Khởi tạo tổng tín chỉ bằng 0.
//
// Sau đó, chúng ta cộng lần lượt tín chỉ của từng môn vào biến này.
int totalCreditHours = 0;

// Toán tử += có nghĩa là:
//
// totalCreditHours = totalCreditHours + course1Credit;
//
// Viết bằng += ngắn gọn hơn nhưng kết quả hoàn toàn giống nhau.
totalCreditHours += course1Credit;
totalCreditHours += course2Credit;
totalCreditHours += course3Credit;
totalCreditHours += course4Credit;
totalCreditHours += course5Credit;

// Với dữ liệu hiện tại:
//
// 3 + 3 + 4 + 4 + 3 = 17 tín chỉ.


// ============================================================================
// BƯỚC 7: TÍNH TỔNG GRADE POINTS
// ============================================================================

// Grade points không chỉ là tổng các điểm 4, 3, 3, 3, 4.
//
// Mỗi điểm phải được nhân với số tín chỉ của môn tương ứng,
// vì môn có nhiều tín chỉ phải có ảnh hưởng lớn hơn đến GPA.
//
// Công thức cho từng môn:
//
// Grade points = Grade × Credit hours
int totalGradePoints = 0;

// English 101:
// 4 điểm × 3 tín chỉ = 12 grade points.
totalGradePoints += course1Grade * course1Credit;

// Algebra 101:
// 3 điểm × 3 tín chỉ = 9 grade points.
totalGradePoints += course2Grade * course2Credit;

// Biology 101:
// 3 điểm × 4 tín chỉ = 12 grade points.
totalGradePoints += course3Grade * course3Credit;

// Computer Science I:
// 3 điểm × 4 tín chỉ = 12 grade points.
totalGradePoints += course4Grade * course4Credit;

// Psychology 101:
// 4 điểm × 3 tín chỉ = 12 grade points.
totalGradePoints += course5Grade * course5Credit;

// Tổng grade points:
//
// 12 + 9 + 12 + 12 + 12 = 57.


// ============================================================================
// BƯỚC 8: TÍNH GPA
// ============================================================================

// Công thức:
//
// GPA = Tổng grade points / Tổng số tín chỉ
//
// Với dữ liệu hiện tại:
//
// GPA = 57 / 17
// GPA = 3.352941...
//
// totalGradePoints và totalCreditHours đều là int.
//
// Nếu viết:
//
// totalGradePoints / totalCreditHours
//
// C# sẽ thực hiện phép chia số nguyên và kết quả chỉ còn 3,
// phần thập phân sẽ bị loại bỏ.
//
// Vì vậy, ta ép kiểu totalGradePoints từ int sang decimal trước khi chia.
decimal gradePointAverage =
    (decimal)totalGradePoints / totalCreditHours;

// Sau khi ép kiểu:
//
// decimal / int
//
// C# sẽ thực hiện phép chia số thập phân,
// nên kết quả 3.352941... được giữ lại.


// ============================================================================
// BƯỚC 9: LẤY BA CHỮ SỐ CẦN HIỂN THỊ
// ============================================================================

// Yêu cầu của bài học là hiển thị GPA dưới dạng:
//
// 3.35
//
// Bài học thực hiện điều này bằng cách tách riêng:
//
// - Chữ số đứng trước dấu thập phân.
// - Chữ số thập phân thứ nhất.
// - Chữ số thập phân thứ hai.


// ----------------------------------------------------------------------------
// 9.1. Lấy chữ số đứng trước dấu thập phân
// ----------------------------------------------------------------------------

// Ép decimal sang int sẽ loại bỏ phần thập phân.
//
// Ví dụ:
//
// (int)3.352941 = 3
//
// Phép ép kiểu này không làm tròn lên.
int leadingDigit = (int)gradePointAverage;


// ----------------------------------------------------------------------------
// 9.2. Lấy chữ số thập phân thứ nhất
// ----------------------------------------------------------------------------

// GPA hiện tại:
//
// 3.352941...
//
// Nhân với 10:
//
// 33.52941...
//
// Ép sang int:
//
// 33
//
// Lấy 33 % 10:
//
// 3
//
// Vì vậy firstDigit bằng 3.
int firstDigit = (int)(gradePointAverage * 10) % 10;


// ----------------------------------------------------------------------------
// 9.3. Lấy chữ số thập phân thứ hai
// ----------------------------------------------------------------------------

// GPA hiện tại:
//
// 3.352941...
//
// Nhân với 100:
//
// 335.2941...
//
// Ép sang int:
//
// 335
//
// Lấy 335 % 10:
//
// 5
//
// Vì vậy secondDigit bằng 5.
int secondDigit = (int)(gradePointAverage * 100) % 10;

// Lưu ý:
//
// Phương pháp của bài học đang cắt bỏ các chữ số phía sau,
// chứ không thực hiện làm tròn toán học.
//
// Với GPA hiện tại, kết quả vẫn là 3.35.


// ============================================================================
// BƯỚC 10: HIỂN THỊ BÁO CÁO
// ============================================================================

// \n là escape sequence tạo một dòng mới.
//
// Sau tên sinh viên, \n tạo thêm một dòng trống
// trước khi hiển thị bảng môn học.
Console.WriteLine($"Student: {studentName}\n");


// ============================================================================
// BƯỚC 11: HIỂN THỊ TIÊU ĐỀ CỦA BẢNG
// ============================================================================

// \t là escape sequence tạo một tab.
//
// Tab được dùng để chia nội dung thành các cột:
//
// Course | Grade | Credit Hours
Console.WriteLine("Course\t\t\tGrade\tCredit Hours");


// ============================================================================
// BƯỚC 12: HIỂN THỊ THÔNG TIN TỪNG MÔN
// ============================================================================

// Những môn có tên ngắn dùng hai tab sau tên môn.
//
// Ví dụ:
//
// English 101 + \t\t
//
// giúp cột Grade được đẩy sang vị trí phù hợp.
Console.WriteLine(
    $"{course1Name}\t\t{course1Grade}\t{course1Credit}");

Console.WriteLine(
    $"{course2Name}\t\t{course2Grade}\t{course2Credit}");

Console.WriteLine(
    $"{course3Name}\t\t{course3Grade}\t{course3Credit}");


// Computer Science I có tên dài hơn các môn khác.
//
// Vì vậy chỉ cần một tab sau tên môn,
// nếu dùng hai tab thì các cột phía sau có thể bị lệch quá xa.
Console.WriteLine(
    $"{course4Name}\t{course4Grade}\t{course4Credit}");

Console.WriteLine(
    $"{course5Name}\t\t{course5Grade}\t{course5Credit}");


// ============================================================================
// BƯỚC 13: HIỂN THỊ GPA CUỐI CÙNG
// ============================================================================

// \n tạo một dòng trống trước kết quả GPA.
//
// Ba phần:
//
// leadingDigit = 3
// firstDigit   = 3
// secondDigit  = 5
//
// được ghép lại thành:
//
// 3.35
Console.WriteLine(
    $"\nFinal GPA:\t\t{leadingDigit}.{firstDigit}{secondDigit}");