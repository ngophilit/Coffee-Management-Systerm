# Chương trình quản lý Quán Cafe

## I. Giới thiệu ứng dụng.
  > Chương trình Quản Lý Quán Cafe là một chương trình quản lý đơn giản với các chức năng thêm, xóa, sửa, tìm kiếm và thống kê. Chương trình này được xây dựng theo mô hình 3 lớp và có 2 phiên bản là ADO.Net và Entity Framework. Chương trình giúp cho người dùng có thể quản lý dữ liệu của 1 cửa hàng bán cafe.
 
## II. Cách sử dụng.
1. Người dùng đăng nhập vào ứng dụng.
2. Sai tên đăng nhập hoặc mật khẩu: Sẽ nhận được thông báo và không đăng nhập được.
3. Đăng nhập thành công:
- Tài khoản của người dùng là tài khoản *nhân viên*:
> Sử dụng được các chức năng sau:
>* Thay đổi thông tin tài khoản của chính mình.
>* Thêm, xóa, sửa hóa đơn.
>* Thêm, xóa, sửa thông tin món của từng hóa đơn.
>* Thanh toán hóa đơn

- Tài khoản của người dùng là tài khoản *Admin*:
> Ngoài các chức năng như của tài khoản nhân viên, thì tài khoản Admin còn được cấp quyền sử dụng các chức năng sau:
>* Thống kê hóa đơn theo khoảng thời gian đã chọn.
>* Thêm, xóa, sửa thông tin của các bảng món ăn, loại món ăn, bàn ăn, tài khoản người dùng.
>* Tìm kiếm món ăn theo tên đã nhập vào.
 
## III. Chi tiết giao diện và chức năng.
### 1. *Form Login.*
![image](https://user-images.githubusercontent.com/75111950/179216913-92427109-46a2-4eea-a1f0-3d662d18320f.png)

Chi tiết: Có các nút sau: 
>+ Nút tắt chương trình “X”: Khi ấn vào nút này sẽ hiện ra 1 bản thông báo để hỏi người dùng có chắc chắn muốn tắt chương trình không. Nếu chọn đồng ý thì chương trình sẽ được tắt. Ngược lại nếu chọn không thì sẽ quay lại giao diện đăng nhập.
>+ Ô textbox để nhập username của người dùng.
>+ Ô textbox để nhập mật khẩu: mật khẩu khi nhập sẽ được hiển thị dưới dạng ẩn(••••••), khi ấn giữ biểu tượng ổ khóa thì sẽ hiện mật khẩu và khi thả ra sẽ về lại dạng ẩn.
>+ Nút Login: Dùng  để đăng nhập, nếu tài khoản và mật khẩu đúng thì giao diện sẽ được chuyển qua giao diện quản lý chung của chương trình. Nếu sai thì sẽ xuất hiện thông báo “Bạn đã nhập sai mật khẩu hoặc username”.
>+ Nút Exit: Khi ấn sẽ thoát khỏi chương trình ngay lập tức.

Ứng dụng: Dùng để đăng nhập vào Giao diện quản lý chung của ứng dụng.

### 2. *Form TableManager.*
![image](https://user-images.githubusercontent.com/75111950/179221181-6da49466-51bd-488c-91ee-b258cc728b76.png)

Chi tiết: Có các nút sau: 
>+ Nút Thêm: Khi ấn vào thì Panel bên phải sẽ mở để nhập các thông tin muốn thêm vào về hóa đơn. Loại hóa đơn thêm vào yêu cầu id không được trùng và idTable phải nằm trong bảng TableFood.
>+ Nút Xóa: Khi ấn vào thì sẽ hiện ra thông báo có muốn xóa dòng đang chọn không. Nếu có thì sẽ xóa dòng đang chọn. Nếu không thì sẽ trở lại giao diện .
>+ Nút Sửa: Khi ấn vào thì Panel bên phải sẽ mở để nhập các thông tin muốn sửa đổi về hóa đơn(trừ id). Hóa đơn được sửa yêu cầu idTable phải nằm trong bảng TableFood.
>+ Nút Lưu: Khi Ấn sẽ tiến hàng lưu dữ liệu(cả của chức năng thêm và sửa).
>+ Nút Hủy: Hủy thức hiện các chức năng thêm hoặc sửa.
>+ Chi tiết hóa đơn: Chuyển đến formBillInfo của hóa đơn đang chọn.
>+ MenuStrip Admin: chuyển đến form Admin ( chỉ tài khoản có type là 1 mới sử dụng được chức năng này).

Ứng dụng: thêm, sửa, xóa các thông tin về hóa đơn.

### 3. *Form BillInfo.*
![image](https://user-images.githubusercontent.com/75111950/179221420-d3811c9c-8bc6-4c2b-b88d-7b9d3d2f7ad9.png)

Chi tiết: Có các nút sau: 
>+ Nút Thêm: Khi ấn vào thì Panel bên phải sẽ mở để nhập các thông tin muốn thêm vào về chi tiết hóa đơn. Loại hóa đơn thêm vào yêu cầu id không được trùng.
>+ Nút Xóa: Khi ấn vào thì sẽ hiện ra thông báo có muốn xóa dòng đang chọn không. Nếu có thì sẽ xóa dòng đang chọn. Nếu không thì sẽ trở lại giao diện .
>+ Nút Sửa: Khi ấn vào thì Panel bên phải sẽ mở để nhập các thông tin muốn sửa đổi về hóa đơn(trừ id và mã hóa đơn). 
>+ Nút Lưu: Khi Ấn sẽ tiến hàng lưu dữ liệu(cả của chức năng thêm và sửa).
>+ Nút Hủy: Hủy thức hiện các chức năng thêm hoặc sửa.
>+ Thanh toán: Thay đổi trạng thái của hóa đơn thành đã thanh toán và chuyển đến form TableManage.

Ứng dụng: thêm, sửa, xóa các thông tin về hóa đơn.

### 4. *Form Account.*
![image](https://user-images.githubusercontent.com/75111950/179221628-de258873-70ec-49e8-aff2-4b3baab99862.png)

Chi tiết:
>+ Ô textbox đăng nhập: Hiển thị tên đăng nhập của người dùng.
>+ Ô textbox tên hiển thị: Yêu cầu người dùng nhập tên hiển thị.
>+ Ô textbox mật khẩu: Yêu cầu người dùng nhập mật khẩu của mình.
>+ Ô textbox mật khẩu mới: Yêu cầu người dùng nhập mật khẩu mới của mình.
>+ Ô textbox nhập lại mật khẩu mới: Yêu cần người dùng nhập lại mật khẩu mới của mình.

Ứng dụng: Dùng để thay đổi thông tin người dùng. 

### 5. *Form Admin.*
![image](https://user-images.githubusercontent.com/75111950/179221792-b4992287-3a73-4575-a06b-5730810674f4.png)

Chi tiết: bao gồm các tab là Doanh thu, thức ăn, loại thức ăn, bàn ăn và tài khoản.
>+ Ở tab Doanh thu sẽ có: ô chọn ngày bắt đầu (ô chọn ngày bên trái) và ô chọn ngày kết thúc (ô chọn ngày bên phải).
>+ Nút thống kê: Khi ấn vào sẽ hiển thị các thông tin về Mã hóa đơn, Tên bàn, Ngày Rời khỏi, Tổng tiền hóa đơn từ ngày bắt đầu cho đến ngày kết thúc đã chọn.

Ứng dụng: thông tin về Mã hóa đơn, Tên bàn, Ngày Rời khỏi, Tổng tiền hóa đơn từ ngày bắt đầu cho đến ngày kết thúc đã chọn.

Tab Thức ăn:

![image](https://user-images.githubusercontent.com/75111950/179221901-63c10eee-880e-4bb3-94f7-4ab8c225a1e2.png)

Chi tiết:
>•	Nút Thêm: Khi ấn vào thì Panel bên phải sẽ mở để nhập các thông tin muốn thêm vào về món ăn. Loại món thêm vào yêu cầu id không được trùng và idCategory phải nằm trong bảng Loại thức ăn.
>•	Nút Xóa: Khi ấn vào thì sẽ hiện ra thông báo có muốn xóa dòng đang chọn không. Nếu có thì sẽ xóa dòng đang chọn. Nếu không thì sẽ trở lại giao diện Admin.
>•	Nút Sửa: Khi ấn vào thì Panel bên phải sẽ mở để nhập các thông tin muốn sửa đổi về món ăn(trừ id). Loại món được sửa yêu cầu idCategory phải nằm trong bảng Loại thức ăn.
>•	Nút Lưu: Khi Ấn sẽ tiến hàng lưu dữ liệu(cả của chức năng thêm và sửa).
>•	Nút Hủy: Hủy thức hiện các chức năng thêm hoặc sửa.
>•	Nút Tìm kiếm: Tìm kiếm ra danh sách các món ăn có trong danh sách món ăn.

Chức năng: Thực hiện các chức năng thêm, xóa, sửa và tìm kiếm cho các món ăn của chương trình.
    
Tab Loại thức ăn:

![image](https://user-images.githubusercontent.com/75111950/179222030-9564c5f8-9ce0-4b4e-bab8-cd12df06460f.png)

Chi tiết:
>•	Nút Thêm: Khi ấn vào thì Panel bên phải sẽ mở để nhập các thông tin muốn thêm vào về loại món ăn. Loại món thêm vào yêu cầu id không được trùng.
>•	Nút Xóa: Khi ấn vào thì sẽ hiện ra thông báo có muốn xóa dòng đang chọn không. Nếu có thì sẽ xóa dòng đang chọn. Nếu không thì sẽ trở lại giao diện Admin.
>•	Nút Sửa: Khi ấn vào thì Panel bên phải sẽ mở để nhập các thông tin muốn sửa đổi về món ăn(trừ id).
>•	Nút Lưu: Khi Ấn sẽ tiến hàng lưu dữ liệu(cả của chức năng thêm và sửa).
>•	Nút Hủy: Hủy thức hiện các chức năng thêm hoặc sửa.

Ứng dụng: Thực hiện các chức năng thêm, xóa, sửa cho các loại món ăn của chương trình.

Tab Bàn ăn:

![image](https://user-images.githubusercontent.com/75111950/179222145-f0c4b1a7-23ed-4e33-a602-00189c67938b.png)

Chi tiết:
>•	Nút Thêm: Khi ấn vào thì Panel bên phải sẽ mở để nhập các thông tin muốn thêm vào về các bàn ăn. Mã bàn ăn thêm vào yêu cầu không được trùng.
>•	Nút Xóa: Khi ấn vào thì sẽ hiện ra thông báo có muốn xóa dòng đang chọn không. Nếu có thì sẽ xóa dòng đang chọn. Nếu không thì sẽ trở lại giao diện Admin.
>•	Nút Sửa: Khi ấn vào thì Panel bên phải sẽ mở để nhập các thông tin muốn sửa đổi về bàn ăn(trừ id).
>•	Nút Lưu: Khi Ấn sẽ tiến hàng lưu dữ liệu(cả của chức năng thêm và sửa).
>•	Nút Hủy: Hủy thức hiện các chức năng thêm hoặc sửa.

Ứng dụng: Thực hiện các chức năng thêm, xóa, sửa cho các bàn ăn của chương trình.

Tab Tài khoản:

![image](https://user-images.githubusercontent.com/75111950/179222251-7d2b6869-e982-43fc-9f4b-675451bcb5a3.png)

Chi tiết:
>•	Nút Thêm: Khi ấn vào thì Panel bên phải sẽ mở để nhập các thông tin muốn thêm vào về tài khoản. Mã tài khoản thêm vào yêu cầu không được trùng.
>•	Nút Xóa: Khi ấn vào thì sẽ hiện ra thông báo có muốn xóa dòng đang chọn không. Nếu có thì sẽ xóa dòng đang chọn. Nếu không thì sẽ trở lại giao diện Admin.
>•	Nút Sửa: Khi ấn vào thì Panel bên phải sẽ mở để nhập các thông tin muốn sửa đổi về tài khoản(trừ id).
>•	Nút Lưu: Khi Ấn sẽ tiến hàng lưu dữ liệu(cả của chức năng thêm và sửa).
>•	Nút Hủy: Hủy thức hiện các chức năng thêm hoặc sửa.

Ứng dụng: Thực hiện các chức năng thêm, xóa, sửa cho các tài khoản của chương trình.

## IV. Kiến trúc phần mềm.
![image](https://user-images.githubusercontent.com/75111950/179222461-11932e93-8427-4af7-945a-3341f075f9d3.png)

1.	FoodCategory Class:

 ![image](https://user-images.githubusercontent.com/75111950/179222632-085ee58a-4b97-4aaf-97c7-36745795ac42.png)

Chi tiết: Bao gồm các thuộc tính sau:
>+ id: Mã loại thức ăn
>+ name: Tên của loại thức ăn
  
Mục đích: Chứa dữ liệu của các loại thức ăn. Từ đó, Bảng Food có thể tham chiếu đến để biết món ăn đó nằm trong loại nhóm thức ăn nào.

2.	Food Class:
 
 ![image](https://user-images.githubusercontent.com/75111950/179222830-5b0ddef6-9fde-4b16-82a8-97a136cc042e.png)

Chi tiết: Bao gồm các thuộc tính sau:
>+ id: Mã món ăn
>+ name: Tên của món ăn ăn
>+ idCategory: Mã loại thức ăn
>+ price: giá của thức ăn

Mục đích: Chứa dữ liệu của các món ăn. Từ đó, Bảng BillInfo có thể tham chiếu đến để biết hóa đơn đó bao gồm những món ăn nào.

3.	TableFood Class:
 
 ![image](https://user-images.githubusercontent.com/75111950/179222954-6f4f747e-19d4-4c53-9c5d-391f1b6dd8ea.png)

Chi tiết: Bao gồm các thuộc tính sau:
>+ id: Mã bàn ăn
>+ name: Tên bàn ăn
>+ Status: Trạng thái bàn ăn (trống/có người)

Mục đích: Chứa dữ liệu của các bàn ăn. Từ đó, Bảng Bill có thể tham chiếu đến để biết hóa đơn đó là của bàn ăn nào.

4.	Bill Class:
 
 ![image](https://user-images.githubusercontent.com/75111950/179223018-53e2315e-5f56-423d-ae02-cf7070b2bfe7.png)

Chi tiết: Bao gồm các thuộc tính sau:
>+ id: Mã hóa đơn
>+ dateCheckIn: Ngày đến
>+ dateCheckOut: Ngày đi
>+ idTable: mã bàn ăn
>+ status: trạng thái hóa đơn(đã thanh toán/chưa thanh toán)
  
Mục đích: Chứa dữ liệu của các hóa đơn. Từ đó, Bảng BillInfo có thể tham chiếu đến để biết chi tiết hóa đơn món ăn đó nằm trong hóa đơn nào.

5.	BillInfo Class:
 
 ![image](https://user-images.githubusercontent.com/75111950/179223114-52dd0ab8-9f83-4714-8e0e-d0cd0a66b2e4.png)

Chi tiết: Bao gồm các thuộc tính sau:
>+ id: Mã hóa đơn chi tiết
>+ idBill: Mã hóa đơn
>+ idFood: Mã món ăn
>+ count: số lượng

Mục đích: Chứa dữ liệu của các hóa đơn chi tiết về từng món ăn đã được gọi. 

6.	Account:
 
 ![image](https://user-images.githubusercontent.com/75111950/179223188-2b6a8eb4-c4ce-43a4-88e6-cb345d5ae437.png)

Chi tiết: Bao gồm các thuộc tính sau:
>+ userName: tên đăng nhập của người dùng
>+ displayName: tên hiện thị của người dùng
>+ password: mật khẩu
>+ accountType: loại tài khoản (1: admin, 2: staff)

Mục đích: Chứa dữ liệu của các tài khoản được sử dụng trong chương trình.

## V. Cơ sở dữ liệu.
![image](https://user-images.githubusercontent.com/75111950/179223354-06b837dc-5997-44b7-828e-56857e015671.png)
