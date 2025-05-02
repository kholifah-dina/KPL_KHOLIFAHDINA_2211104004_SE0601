from enum import Enum

class StudentStatus(Enum):
    TERDAFTAR = "Terdaftar"
    AKTIF = "Aktif"
    LULUS = "Lulus"
    CUTI = "Cuti"

class TriggerInputState(Enum):
    CETAK_KSM = "Cetak KSM"
    MENGAJUKAN_CUTI = "Mengajukan Cuti"
    LULUS = "Lulus"
    MENYELESAIKAN_CUTI = "Menyelesaikan Cuti"

# Transisi antar status berdasarkan trigger
transition = {
    StudentStatus.TERDAFTAR: {
        TriggerInputState.CETAK_KSM: StudentStatus.AKTIF,
        TriggerInputState.MENGAJUKAN_CUTI: StudentStatus.CUTI,
    },
    StudentStatus.AKTIF: {
        TriggerInputState.LULUS: StudentStatus.LULUS,
        TriggerInputState.MENGAJUKAN_CUTI: StudentStatus.CUTI,
    },
    StudentStatus.CUTI: {
        TriggerInputState.MENYELESAIKAN_CUTI: StudentStatus.TERDAFTAR,
    },
}

def change_state(current_state, trigger_input):
    """Mengubah status mahasiswa berdasarkan input trigger."""
    if current_state not in transition or trigger_input not in transition[current_state]:
        return "Transisi tidak valid"
    return transition[current_state][trigger_input]

# Simulasi perubahan status mahasiswa
current_state = StudentStatus.TERDAFTAR 

# Uji perubahan status dengan CETAK_KSM
next_state = change_state(current_state, TriggerInputState.CETAK_KSM) 
print(f"Next State => {next_state.value}")

# Uji perubahan status dengan LULUS (seharusnya tidak valid)
next_state = change_state(current_state, TriggerInputState.LULUS)
print(f"Next State => {next_state}")