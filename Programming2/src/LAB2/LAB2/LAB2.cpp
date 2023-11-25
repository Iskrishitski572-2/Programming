#include <iostream>
#include <algorithm>
using namespace std;

template <typename T> // Можем использовать массив любого типа данных

struct DynamicArray
{
    T* array;     // Указатель на массив
    int length;   // Текущая длина массива
    int capacity; // Емкость массива

    DynamicArray()
    {
        length = 0;
        capacity = 8;
        array = new T[capacity];
    }
    ~DynamicArray()
    {
        delete[] array;
    }

    void Add(T item) // case 1 и case 4
    {
        array[length++] = item;
    }

    void Del(T item) // case 2
    {
        for (int i = 0; i < length; i++)
        {
            if (array[i] == item)
            {
                for (int j = i; j < length - 1; j++)
                {
                    array[j] = array[j + 1];
                }
                length--;
                return;
            }
        }
    }

    void InsertFirst(T item) // case 3
    {
        for (int i = length; i > 0;i--)
        {
            array[i] = array[i - 1];
        }
        array[0] = item;
        length++;
    }

    void InsertAt(T item, T item1)  //case 5
    {
        for (int i = 0; i < length; i++)
        {
            if (array[i] == item1)
            {
                for (int j = length; j > i; j--)
                {
                    array[j] = array[j - 1];
                }
                array[i + 1] = item;
                length++;
                return;
            }
        }
    }

    void Sort()  // case 6
    {
        sort(array, array + length);
    }

    int LinSearch(T item)
    {
        for (int i = 0; i < length; i++)
        {
            if (array[i] == item)
            {
                return i;
            }
        }
        return -1;
    }

    int BinSearch(T item)
    {
        int left = 0;
        int right = length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (array[mid] == item)
            {
                return mid; // Возвращаем индекс элемента, если найден
            }
            if (array[mid] < item)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return -1;
    }

    void Display()  // case 9
    {
        for (int i = 0; i < length; i++)
        {
            cout << array[i] << " ";
        }
        cout << endl;
    }
};