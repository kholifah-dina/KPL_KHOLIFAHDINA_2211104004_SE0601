from enum import Enum
import time

class TrafficLightState(Enum): 
    MERAH = "Merah"
    HIJAU = "Hijau"
    KUNING = "Kuning"

# Transisi antar status
state_transition = {
    TrafficLightState.MERAH: TrafficLightState.HIJAU,
    TrafficLightState.HIJAU: TrafficLightState.KUNING,
    TrafficLightState.KUNING: TrafficLightState.MERAH,
}

# Durasi tiap status (dalam detik)
state_duration = {
    TrafficLightState.MERAH: 5,
    TrafficLightState.HIJAU: 10,
    TrafficLightState.KUNING: 2,
}

# Mulai dari lampu merah
current_state = TrafficLightState.MERAH

while True:
    print(f"Current State: {current_state.value} ({state_duration[current_state]} detik)")
    time.sleep(state_duration[current_state])  # Tunggu sesuai durasi state saat ini
    current_state = state_transition[current_state]  # Pindah ke state berikutnya
    print(f"Next State: {current_state.value}\n")