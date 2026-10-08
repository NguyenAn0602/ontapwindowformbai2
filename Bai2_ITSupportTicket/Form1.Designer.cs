namespace Bai2_ITSupportTicket;

partial class Form1
{
    private System.ComponentModel.IContainer? components = null;

    private Label lblTitle = null!;
    private GroupBox grpThongTin = null!;
    private Label lblMaPhieu = null!;
    private TextBox txtMaPhieu = null!;
    private Label lblNguoiYeuCau = null!;
    private TextBox txtNguoiYeuCau = null!;
    private Label lblNgay = null!;
    private DateTimePicker dtpNgayGhiNhan = null!;
    private GroupBox grpUuTien = null!;
    private RadioButton radThap = null!;
    private RadioButton radTrungBinh = null!;
    private RadioButton radKhanCap = null!;
    private GroupBox grpChiTiet = null!;
    private Label lblLoaiSuCo = null!;
    private ComboBox cboLoaiSuCo = null!;
    private Label lblThietBi = null!;
    private CheckBox chkMayTinhBan = null!;
    private CheckBox chkLaptop = null!;
    private CheckBox chkMayIn = null!;
    private CheckBox chkDienThoai = null!;
    private PictureBox picAnhLoi = null!;
    private Button btnTaiAnh = null!;
    private Button btnGuiYeuCau = null!;
    private Button btnNhapLai = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblTitle = new Label();
        grpThongTin = new GroupBox();
        lblMaPhieu = new Label();
        txtMaPhieu = new TextBox();
        lblNguoiYeuCau = new Label();
        txtNguoiYeuCau = new TextBox();
        lblNgay = new Label();
        dtpNgayGhiNhan = new DateTimePicker();
        grpUuTien = new GroupBox();
        radThap = new RadioButton();
        radTrungBinh = new RadioButton();
        radKhanCap = new RadioButton();
        grpChiTiet = new GroupBox();
        lblLoaiSuCo = new Label();
        cboLoaiSuCo = new ComboBox();
        lblThietBi = new Label();
        chkMayTinhBan = new CheckBox();
        chkLaptop = new CheckBox();
        chkMayIn = new CheckBox();
        chkDienThoai = new CheckBox();
        picAnhLoi = new PictureBox();
        btnTaiAnh = new Button();
        btnGuiYeuCau = new Button();
        btnNhapLai = new Button();

        SuspendLayout();

        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        lblTitle.Location = new Point(205, 20);
        lblTitle.Text = "TIẾP NHẬN SỰ CỐ IT";

        grpThongTin.Location = new Point(25, 80);
        grpThongTin.Size = new Size(650, 225);
        grpThongTin.Text = "Thông tin phiếu";

        lblMaPhieu.AutoSize = true;
        lblMaPhieu.Location = new Point(25, 40);
        lblMaPhieu.Text = "Mã phiếu:";
        txtMaPhieu.Location = new Point(180, 36);
        txtMaPhieu.Size = new Size(430, 30);
        txtMaPhieu.TabIndex = 0;

        lblNguoiYeuCau.AutoSize = true;
        lblNguoiYeuCau.Location = new Point(25, 82);
        lblNguoiYeuCau.Text = "Người yêu cầu:";
        txtNguoiYeuCau.Location = new Point(180, 78);
        txtNguoiYeuCau.Size = new Size(430, 30);
        txtNguoiYeuCau.TabIndex = 1;

        lblNgay.AutoSize = true;
        lblNgay.Location = new Point(25, 124);
        lblNgay.Text = "Ngày ghi nhận:";
        dtpNgayGhiNhan.Location = new Point(180, 120);
        dtpNgayGhiNhan.Size = new Size(220, 30);
        dtpNgayGhiNhan.Format = DateTimePickerFormat.Short;
        dtpNgayGhiNhan.TabIndex = 2;

        grpUuTien.Location = new Point(25, 160);
        grpUuTien.Size = new Size(585, 55);
        grpUuTien.Text = "Mức độ ưu tiên";

        radThap.AutoSize = true;
        radThap.Location = new Point(20, 23);
        radThap.Text = "Thấp";
        radThap.TabIndex = 3;

        radTrungBinh.AutoSize = true;
        radTrungBinh.Location = new Point(190, 23);
        radTrungBinh.Text = "Trung bình";
        radTrungBinh.TabIndex = 4;

        radKhanCap.AutoSize = true;
        radKhanCap.Location = new Point(390, 23);
        radKhanCap.Text = "Khẩn cấp";
        radKhanCap.TabIndex = 5;

        grpUuTien.Controls.AddRange([radThap, radTrungBinh, radKhanCap]);
        grpThongTin.Controls.AddRange([
            lblMaPhieu, txtMaPhieu, lblNguoiYeuCau, txtNguoiYeuCau,
            lblNgay, dtpNgayGhiNhan, grpUuTien
        ]);

        grpChiTiet.Location = new Point(25, 320);
        grpChiTiet.Size = new Size(650, 300);
        grpChiTiet.Text = "Phân loại & chi tiết";

        lblLoaiSuCo.AutoSize = true;
        lblLoaiSuCo.Location = new Point(25, 42);
        lblLoaiSuCo.Text = "Loại sự cố:";
        cboLoaiSuCo.Location = new Point(180, 38);
        cboLoaiSuCo.Size = new Size(250, 31);
        cboLoaiSuCo.DropDownStyle = ComboBoxStyle.DropDownList;
        cboLoaiSuCo.Items.AddRange(["Phần cứng", "Phần mềm", "Mạng", "Tài khoản"]);
        cboLoaiSuCo.TabIndex = 6;

        lblThietBi.AutoSize = true;
        lblThietBi.Location = new Point(25, 90);
        lblThietBi.Text = "Thiết bị ảnh hưởng:";

        chkMayTinhBan.AutoSize = true;
        chkMayTinhBan.Location = new Point(180, 88);
        chkMayTinhBan.Text = "Máy tính bàn";
        chkMayTinhBan.TabIndex = 7;

        chkLaptop.AutoSize = true;
        chkLaptop.Location = new Point(365, 88);
        chkLaptop.Text = "Laptop";
        chkLaptop.TabIndex = 8;

        chkMayIn.AutoSize = true;
        chkMayIn.Location = new Point(180, 125);
        chkMayIn.Text = "Máy in";
        chkMayIn.TabIndex = 9;

        chkDienThoai.AutoSize = true;
        chkDienThoai.Location = new Point(365, 125);
        chkDienThoai.Text = "Điện thoại";
        chkDienThoai.TabIndex = 10;

        picAnhLoi.BorderStyle = BorderStyle.FixedSingle;
        picAnhLoi.Location = new Point(180, 165);
        picAnhLoi.Size = new Size(250, 115);
        picAnhLoi.SizeMode = PictureBoxSizeMode.StretchImage;

        btnTaiAnh.Location = new Point(455, 165);
        btnTaiAnh.Size = new Size(155, 45);
        btnTaiAnh.Text = "Tải ảnh lỗi";
        btnTaiAnh.TabIndex = 11;
        btnTaiAnh.Click += btnTaiAnh_Click;

        grpChiTiet.Controls.AddRange([
            lblLoaiSuCo, cboLoaiSuCo, lblThietBi,
            chkMayTinhBan, chkLaptop, chkMayIn, chkDienThoai,
            picAnhLoi, btnTaiAnh
        ]);

        btnGuiYeuCau.Location = new Point(195, 640);
        btnGuiYeuCau.Size = new Size(145, 45);
        btnGuiYeuCau.Text = "Gửi yêu cầu";
        btnGuiYeuCau.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnGuiYeuCau.TabIndex = 12;
        btnGuiYeuCau.Click += btnGuiYeuCau_Click;

        btnNhapLai.Location = new Point(365, 640);
        btnNhapLai.Size = new Size(145, 45);
        btnNhapLai.Text = "Nhập lại";
        btnNhapLai.TabIndex = 13;
        btnNhapLai.Click += btnNhapLai_Click;

        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(705, 710);
        Controls.AddRange([lblTitle, grpThongTin, grpChiTiet, btnGuiYeuCau, btnNhapLai]);
        Font = new Font("Segoe UI", 10F);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Bài 2 - IT Support Ticket Form";
        ResumeLayout(false);
        PerformLayout();
    }
}
