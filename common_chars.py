def get_common_chars(strings):

    for s1 in strings:
        for s2 in strings:
            common_chars = ''.join(a for a, b in zip(s1, s2) if a == b)

            if len(common_chars) == len(s1) - 1:
                return common_chars

    return ''
