import sys
import math
import signal


class TimeoutException(Exception):
    pass

def timeout_handler(signum, frame):
    raise TimeoutException


def compare_files(file1, file2):
    with open(file1, "rb") as f1, open(file2, "rb") as f2:
        bytes1 = f1.read()
        bytes2 = f2.read()
        if(len(bytes1) > 1000000 or len(bytes2) > 1000000):
            return 0
        matches = 0
        for i in range(0, len(bytes1) - 50, 50):
            if bytes1[i:i+50] in bytes2:
                matches += 1

        similarity = matches / (len(bytes1) / 50)
        
        return similarity

if __name__ == '__main__':
    if len(sys.argv) != 3:
        print('Usage: python similarity.py file1 file2')
        sys.exit(1)
    file1 = sys.argv[1]
    file2 = sys.argv[2]
    
    similarity = compare_files(file1, file2)
    print(similarity * 100)
    # print(math.ceil(similarity * 100))
    
     
    
   