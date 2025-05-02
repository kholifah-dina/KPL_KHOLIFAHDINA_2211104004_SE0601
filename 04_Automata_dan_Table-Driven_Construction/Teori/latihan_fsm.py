from enum import Enum

# Definisi status dalam mesin vending
class VendingState(Enum):
    IDLE = "Idle"
    MENUNGGU_PRODUK = "MenungguProduk"
    MENGELUARKAN_PRODUK = "MengeluarkanProduk"
    SELESAI = "Selesai"

# Definisi input atau trigger yang menyebabkan transisi antar status
class Trigger(Enum):
    MASUKKAN_UANG = "Masukkan Uang"
    PILIH_PRODUK = "Pilih Produk"
    RESET = "Reset"
    KELUARKAN_PRODUK = "Keluarkan Produk"

# Transisi status berdasarkan input
transitions = {
    VendingState.IDLE: {
        Trigger.MASUKKAN_UANG: VendingState.MENUNGGU_PRODUK
    },
    VendingState.MENUNGGU_PRODUK: {
        Trigger.PILIH_PRODUK: VendingState.MENGELUARKAN_PRODUK,
        Trigger.RESET: VendingState.IDLE
    },
    VendingState.MENGELUARKAN_PRODUK: {
        Trigger.KELUARKAN_PRODUK: VendingState.SELESAI
    },
    VendingState.SELESAI: {
        # Tidak ada transisi setelah selesai
    }
}

# Fungsi untuk mengubah status berdasarkan input
def change_state(current_state, trigger):
    if trigger in transitions.get(current_state, {}):
        return transitions[current_state][trigger]
    return current_state  # Jika tidak ada transisi yang valid, tetap di status yang sama

# Simulasi FSM
current_state = VendingState.IDLE

print(f"State Awal: {current_state.value}")

# Transisi pertama: Masukkan uang
current_state = change_state(current_state, Trigger.MASUKKAN_UANG)
print(f"State Setelah Masukkan Uang: {current_state.value}")

# Transisi kedua: Pilih produk
current_state = change_state(current_state, Trigger.PILIH_PRODUK)
print(f"State Setelah Pilih Produk: {current_state.value}")

# Transisi ketiga: Keluarkan produk
current_state = change_state(current_state, Trigger.KELUARKAN_PRODUK)
print(f"State Setelah Keluarkan Produk: {current_state.value}")
