# import math 

# x1 = int(input('Введите кооринту x1: '))
# y1 = int(input('Введите кооринту y1: '))

# x2 = int(input('Введите кооринту x2: '))
# y2 = int(input('Введите кооринту y2: '))

# result = math.sqrt((x2 - x1)**2 + (y2 - y1)**2)
# print(round(result, 5))

# 12. Для натурального n создать словарь индекс-значение, 
# состоящий из элементов последовательности 3n + 1.
n = int(input('Введите число: '))
count = {}
for i in range (1, n + 1):
    count [i] = 3 * i + 1
print(count, end=", ")

# 13. Напишите программу, в которой пользователь будет 
# задавать две строки, а программа - определять количество 
# вхождений одной строки в другой.
# str1 = input('Введите строку 1: ')
# str2 = input('Введите строку 2: ')
# counter = 0

# for i in range(len(str2)):
#     if str1 == str2[i: i+len(str1)]:
#         counter += 1
# print(counter)

