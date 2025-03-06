from enum import Enum

class JenisKelamin(Enum):
    PRIA = 1
    WANITA = 2

patients = []

def add_patients(name : str, gender: JenisKelamin):
    if not isinstance(gender, JenisKelamin):
        raise ValueError("Jenis kelamin itu harus PRIA atau WANITA")

    patients.append({"name": name,"gender": gender.name,})
    print(f"Berhasil menambahkan pasien {name} dengan jenis kelamin {gender.name}")

add_patients("Andi", JenisKelamin.PRIA)
add_patients("Siti", JenisKelamin.WANITA)