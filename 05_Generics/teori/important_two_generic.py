# contoh 2
from typing import List

def jumlahkan(data: List[int]) -> int:
    return sum(data)

print(jumlahkan([1,2,3,4,5]))

# import untuk generic
from typing import TypeVar

# T=semua tipe data (int, float, str, dll)
T = TypeVar('T')

def maximum(a: T, b:T) -> T:
    return a if a > b else b

print(maximum(3, 5))
print(maximum(1.5, 5.3))
print(maximum('k', 'Q'))