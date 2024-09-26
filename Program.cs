using System;
using System.Collections.Generic;

// Kelas Hewan
class Hewan
{
    public string Nama { get; set; }
    public int Umur { get; set; }

    // Method untuk suara hewan
    public virtual string Suara()
    {
        return "Hewan ini bersuara";
    }

    // Method untuk informasi dasar hewan
    public virtual string InfoHewan()
    {
        return $"Nama: {Nama}, Umur: {Umur} tahun";
    }
}

// Kelas Mamalia yang mewarisi Hewan
class Mamalia : Hewan
{
    public int JumlahKaki { get; set; }

    // Override method Suara()
    public override string Suara()
    {
        return "Mamalia ini bersuara";
    }

    // Override method InfoHewan()
    public override string InfoHewan()
    {
        return base.InfoHewan() + $", Jumlah Kaki: {JumlahKaki}";
    }
}

// Kelas Reptil yang mewarisi Hewan
class Reptil : Hewan
{
    public double PanjangTubuh { get; set; }

    // Override method Suara()
    public override string Suara()
    {
        return "Reptil ini bersuara";
    }

    // Override method InfoHewan()
    public override string InfoHewan()
    {
        return base.InfoHewan() + $", Panjang Tubuh: {PanjangTubuh} meter";
    }
}

// Kelas Singa yang mewarisi Mamalia
class Singa : Mamalia
{
    public Singa(string nama, int umur)
    {
        Nama = nama;
        Umur = umur;
        JumlahKaki = 4;
    }

    // Method khusus Mengaum
    public void Mengaum()
    {
        Console.WriteLine($"{Nama} mengaum!");
    }

    public override string InfoHewan()
    {
        return $"Nama Singa: {Nama}, Umur: {Umur} tahun, Jumlah Kaki: {JumlahKaki}";
    }

    // Override method Suara()
    public override string Suara()
    {
        return "Roarrrrrr!";
    }
}

// Kelas Gajah yang mewarisi Mamalia
class Gajah : Mamalia
{
    public Gajah(string nama, int umur)
    {
        Nama = nama;
        Umur = umur;
        JumlahKaki = 4;
    }

    public override string InfoHewan()
    {
        return $"Nama Gajah: {Nama}, Umur: {Umur} tahun, Jumlah Kaki: {JumlahKaki}";
    }

    // Override method Suara()
    public override string Suara()
    {
        return "Trumpet!";
    }
}

// Kelas Ular yang mewarisi Reptil
class Ular : Reptil
{
    public Ular(string nama, int umur)
    {
        Nama = nama;
        Umur = umur;
        PanjangTubuh = 2.5; // Contoh panjang tubuh dalam meter
    }

    public override string InfoHewan()
    {
        return $"Nama Ular: {Nama}, Umur: {Umur} tahun, Panjang Tubuh: {PanjangTubuh} meter";
    }

    // Method khusus Merayap
    public void Merayap()
    {
        Console.WriteLine($"{Nama} sedang merayap!");
    }

    // Override method Suara()
    public override string Suara()
    {
        return "SSSsssssssstttttttt!";
    }
}

// Kelas Buaya yang mewarisi Reptil
class Buaya : Reptil
{
    public Buaya(string nama, int umur)
    {
        Nama = nama;
        Umur = umur;
        PanjangTubuh = 3.0; // Contoh panjang tubuh dalam meter
    }

    public override string InfoHewan()
    {
        return $"Nama Buaya: {Nama}, Umur: {Umur} tahun, Panjang Tubuh: {PanjangTubuh} meter";
    }

    // Override method Suara()
    public override string Suara()
    {
        return "kamu ko cantik bangettt";
    }
}

// Kelas KebunBinatang untuk mengelola koleksi hewan
class KebunBinatang
{
    private List<Hewan> koleksiHewan;

    public KebunBinatang()
    {
        koleksiHewan = new List<Hewan>();
    }

    // Method untuk menambah hewan ke koleksi
    public void TambahHewan(Hewan hewan)
    {
        koleksiHewan.Add(hewan);
        Console.WriteLine($"{hewan.Nama} telah ditambahkan ke kebun binatang.");
    }

    // Method untuk menampilkan daftar hewan di kebun binatang
    public void DaftarHewan()
    {
        Console.WriteLine("\nDaftar Hewan di Kebun Binatang:");
        foreach (var hewan in koleksiHewan)
        {
            Console.WriteLine(hewan.InfoHewan());
            Console.WriteLine($"Suara: {hewan.Suara()}");
            Console.WriteLine();
        }
    }
}

// Program utama
class Program
{
    static void Main(string[] args)
    {
        // Membuat objek kebun binatang
        KebunBinatang kebunBinatang = new KebunBinatang();

        // Membuat beberapa objek dari berbagai jenis hewan
        Singa singa = new Singa("Athenaa", 5);
        Gajah gajah = new Gajah("Jeniper", 10);
        Ular ular = new Ular("Sanca", 3);
        Buaya buaya = new Buaya("Alexander", 7);

        // Menambahkan hewan-hewan tersebut ke kebun binatang
        kebunBinatang.TambahHewan(singa);
        kebunBinatang.TambahHewan(gajah);
        kebunBinatang.TambahHewan(ular);
        kebunBinatang.TambahHewan(buaya);

        // Menampilkan semua hewan di kebun binatang
        kebunBinatang.DaftarHewan();

        // Demonstrasi penggunaan polymorphism dengan memanggil method Suara() untuk beberapa hewan berbeda
        Hewan[] hewanArray = { singa, gajah, ular, buaya };
        foreach (var hewan in hewanArray)
        {
            Console.WriteLine($"{hewan.Nama} bersuara: {hewan.Suara()}");
        }

        // Panggil method khusus untuk Singa
        singa.Mengaum();
    }
}