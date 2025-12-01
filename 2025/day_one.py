input_file = 'input'
curr_pos = 50
max_dial = 99
min_dial = 0
zero_count = 0

lines = [line.strip('\n') for line in open(input_file, 'r').readlines()]


#for line in lines:
#    print(line)

subtract = False

for line in lines:
    if line[0] == "R":
        subtract = False
    elif line[0] == "L":
        subtract = True
    
    if subtract is True:
        curr_pos = curr_pos - int(line[1:])
    else:
        curr_pos = curr_pos + int(line[1:])
    
    curr_pos = curr_pos%100
    
    if curr_pos == 0:
        zero_count = zero_count + 1

print(zero_count)

