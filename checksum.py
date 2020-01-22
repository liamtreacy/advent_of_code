def get_checksum(strings):
    two_count = 0
    three_count = 0

    for s in strings:
        found_two = False
        found_three = False

        for i in range(0, len(s)):

            if s.count(str(s[i])) is 2:
                found_two = True
            if s.count(str(s[i])) is 3:
                found_three = True

        if found_two is True:
            two_count += 1
            found_two = False
        if found_three is True:
            three_count +=1
            found_three = False

    return two_count*three_count
