using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice251223
{
    class Programe
    {

        static List<Item> _items = new List<Item>();

        /// <summary>
        /// 아이템을 찾는 용도
        /// </summary>
        /// <param name="item">아이템</param>
        /// <returns>bool을 반환</returns>
        delegate bool ItemSelector(Item item);

        static Action<int> action;

    
        enum ItemType
        {
            Weapon,
            Armor,
            Amulet,
            Ring,
        }
    
        enum Rarity
        {
             Normal,
             Magic,
             Rare,
        }


        // 인벤토리 시스템을 만든다 가정
        // 아이템의 객체 분리
        // 아이템을 많이 들고 있다 > 그것이 인벤토리
        // 무슨 아이템인지
        // 자료구조
        class Item
        {
            public ItemType itemType;
            public Rarity rarity;
        }

        static Item FindItem(ItemSelector itemSelector)
        {
            foreach (Item item in _items)
            {
                if (itemSelector(item))
                    return item;
            }
            return null;
        } // >> 일일이 만들어야 하네 > 델리게이트로

        static bool IsWeapon(Item item)
        {
            return item.itemType == ItemType.Weapon;
        } // 이것도 다 일일이 만들어야 하네 > 델리게이트로 > 어 근데 굳이 만들어? 한번만 쓸건데? 이럴때 쓰는게 Lambda 다


        class Lambda
        {

            // Lambda : 일회용 함수를 만드는 문법
       
            static void Ma0in()
            {
                _items.Add(new Item() { itemType = ItemType.Weapon, rarity = Rarity.Normal});
                _items.Add(new Item() { itemType = ItemType.Armor, rarity = Rarity.Normal });
                _items.Add(new Item() { itemType = ItemType.Weapon, rarity = Rarity.Normal });

                //  가상의 인벤토리
                // 우리가 아이템 종류 또는 아이템 등급에 따라서 아이콘의 색이나 아이콘 이미지를 변경하려고 할때

                Item weapon = FindItem((Item item) => { return item.itemType == ItemType.Weapon;  }); //delegate 대체로 화살표도 사용이 가능하다
                Item ring = FindItem(i => { return i.itemType == ItemType.Ring;  });
                Item armor = FindItem(delegate (Item item) { return item.itemType == ItemType.Armor;  }); //한번만 사용하고 더이상 안 할거니까
                // 계속 쓸거면 람다보단 함수가 낫다
                // Lambda안에 Lamda를 쓸 수는 있는데 굳이 그렇게 쓰지는 않는다\

                action += (int i) => { };
                // int를 매개변수로 하고 반환이 없는
            }
        }
    }
}
