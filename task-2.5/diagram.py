import matplotlib.pyplot as plt

array_sizes = [5, 10, 50, 100]
execution_times = [1, 2, 10, 50]

plt.figure(figsize=(10, 6))
plt.plot(array_sizes, execution_times, marker='o', linestyle='-', color='b')

plt.title('Время выполнения сортировки выбором')
plt.xlabel('Размер массива')
plt.ylabel('Время (мс)')
plt.grid(True)

for i, txt in enumerate(execution_times):
    plt.annotate(f'{txt} ms', (array_sizes[i], execution_times[i]), textcoords="offset points", xytext=(0, 10), ha='center')

plt.show()
