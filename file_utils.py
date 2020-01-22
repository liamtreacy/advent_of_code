def read_file_to_list(filename):
    lines = []
    with open(filename) as f:
        for line in f:
            lines.append(line)

    return lines