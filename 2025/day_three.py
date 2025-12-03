lines = [line.strip('\n') for line in open('input', 'r').readlines()]

print(lines)

total_joltage = 0
large_one = 0
large_two = 0

for line in lines:
    tmp_line = ''

    for c in line:
        n = int(c)
        if n > large_one:
            large_one = n

    index = line.find(str(large_one))

    if index == len(line) - 1:
        large_two = large_one
        large_one = 0
        substring = line[:index]
        print(substring)
        for c in substring:
            n = int(c)
            if n > large_one:
                large_one = n
    else:
        large_one = large_one
        substring = line[index+1:]
        print(index)
        print(substring)
    
        for c in substring:
            n = int(c)
            if n > large_two:
                large_two = n
    
    tmp_str = str(large_one) + str(large_two)
    print(tmp_str)
    print('-')
    large_one = 0
    large_two = 0
    total_joltage = total_joltage + int(tmp_str)


print('----')
print(total_joltage)