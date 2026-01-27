# Input
responseTimes = [100, 200, 150,300]


#############################
count = 0
for i in range(len(responseTimes)):
    if i == 0:
        continue

    sum = 0
    for j in range(0, i):
        sum += responseTimes[j]

    average = sum / i

    if responseTimes[i] > average:
        count += 1

print(count) # return count


    
    
