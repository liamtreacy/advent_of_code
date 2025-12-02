def isMatch(n):
    s = str(n)
    if len(s) % 2 == 0:
        first_half, second_half = int(s[:len(s)//2]), int(s[len(s)//2:])
        if first_half == second_half:
            return True
    else:
        return False
    return False

total_invalid_ids = 0
total_invalid_sum = 0

with open('input', 'r') as file:
    line = file.readline().strip()

entries = line.split(',')

for entry in entries:
    if(entry is not ''):
        print(entry)
        numbers = [int(x) for x in entry.split('-')]
        print(numbers)   
        for i in range(numbers[0], numbers[1]+1):
            if(isMatch(i)):
                total_invalid_sum = total_invalid_sum + i
            print(i)  # Or whatever you want to print

        print('')

print('-----')
print(total_invalid_sum)