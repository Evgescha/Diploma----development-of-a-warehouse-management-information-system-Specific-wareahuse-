# Разработка информационной системы управления складом (2022)
Система позволит автоматизировать процесс хранения и поиска различной информации о схемах, а также ведение данных о закупках и продажах схем выбранным заказчикам, уменьшит количество ошибок при вводе данных, исключит возможность потери данных при длительном хранении, увеличит производительность сотрудников благодаря снижению времени на поиск и отображение информации.

Диаграмма вариантов использования

![image](https://github.com/Evgescha/Diploma----development-of-a-warehouse-management-information-system-Specific-wareahuse-/assets/38140129/27d6365c-c734-44ae-982e-37066a588e2f)


В процессе разработки системы были выделены следующие сущности, используемые для хранения данных:
–	Товары поставки
–	Склад
–	Товар
–	Поставка
–	Товары заказа
–	Заказчик грузополучатель
–	Заказ
–	Заказчик

![image](https://github.com/Evgescha/Diploma----development-of-a-warehouse-management-information-system-Specific-wareahuse-/assets/38140129/513f80d9-ebbf-4348-adfe-226529a6aab7)


## Разработка интерфейса программного продукта

Реализацию вариантов использования, а также описание взаимодействия системы с пользователем можно представить в виде скриншотов отображения смены форм посредством работы пользователя.

 ![image](https://github.com/Evgescha/Diploma----development-of-a-warehouse-management-information-system-Specific-wareahuse-/assets/38140129/d68b78af-0e32-4896-9eb1-a789a1ed1398)

Рисунок 3.2 – Главная форма

Каждый пункт меню отвечает за свою подсистему. 
 
 ![image](https://github.com/Evgescha/Diploma----development-of-a-warehouse-management-information-system-Specific-wareahuse-/assets/38140129/aa684fdf-aba7-47bc-9749-11ed00c60c29)

Рисунок 3.3 – Модуль работы с заказчиками

При выборе пункта перехода к подсистеме заказчиков будет доступна форма работы с заказчиками. Кроме того, на ней будут отображены список заказов выбранного заказчика, а также работа с грузополучателями заказчика.

 ![image](https://github.com/Evgescha/Diploma----development-of-a-warehouse-management-information-system-Specific-wareahuse-/assets/38140129/c6e82dba-facf-4074-b726-ff575335daf4)

Рисунок 3.4 – Модуль работы с заказами

При выборе пункта перехода к подсистеме заказов будет отображен также список всех товаров заказа.
 
 ![image](https://github.com/Evgescha/Diploma----development-of-a-warehouse-management-information-system-Specific-wareahuse-/assets/38140129/1053c74e-406f-402a-abce-2fbbcf0851e9)

Рисунок 3.5 – Модуль работы с товарами

При выборе пункта перехода к подсистеме на данной форме будет возможность просматривать информацию о товарах, а также возможность загружать товары с xmls файла.

 ![image](https://github.com/Evgescha/Diploma----development-of-a-warehouse-management-information-system-Specific-wareahuse-/assets/38140129/cd1734a7-886a-469b-aa79-401ce9404035)

Рисунок 3.6 – Модуль работы с поставками

При выборе пункта перехода к подсистеме поставок будет отображена похожая форма, как и при работе с заказами. 

 ![image](https://github.com/Evgescha/Diploma----development-of-a-warehouse-management-information-system-Specific-wareahuse-/assets/38140129/982954cc-2fc9-47d7-823c-303f8460b82d)

Рисунок 3.7 – Модуль работы с складом

При выборе пункта перехода к подсистеме склада будет отображена форма работы со складом. На ней будет возможность увидеть всю информацию о товаром.

 ![image](https://github.com/Evgescha/Diploma----development-of-a-warehouse-management-information-system-Specific-wareahuse-/assets/38140129/ed321cd1-3e23-4e6d-9c7b-cdaaec803099)

Рисунок 3.8 – Модуль работы с рейтингом товаров

При выборе пункта перехода к подсистеме рейтинга, будет отображена информация о том, какой товаро сколько раз продавался, заказывался и тд.

