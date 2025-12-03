using System;
using System.Runtime.InteropServices;

class OOP
{
	public OOP()
	{
		// OOP의 4대 원칙 > 애시당초 잘못되었어!
		// 그냥 유기적으로 연결된 개념인데

		
		// static void


	}   
}
// 클래스
// class (클래스이름) {} > 이렇게 만든다
// 지역변수 멤버변수
// 클래스 : 설계도
// 호출할때는? static을 왜 붙였는가
// 객체를 알고 가보자

#region
class Car // 이 아래에 기능과 속성을 주는 것 => 클래스를 정의한다
{
	// 객체란 무엇인가 : 모든 것을 말한다
	// 엔진, 배터리 (실체가 있는 것), 운전 , 소리(실체가 없는 것)
	// 객체끼리 상호작용을 통해서 문제를 해결하는 방식을 객체지향이라 한다.
	public Engine engine = new Engine(); // 속성
	public Battery battery = new Battery(); //아직은 없지만 > 직접 만들 수 있다



	public void move()// 기능
	{

	}
    public void repair()
    {
		engine.Check();
		battery.Disconnected();
	    // 객체에서 먼저 기능 만들고 또다른 class에서 호출해서 다 만들 수 있게 하는 방식
		// 객체 지향적 문제 해결

    }
}

class Engine() // 사용자 지정 형식
{
 // 엔진에서만 할 수 있는 것
  public void Check()
	{
		Console.WriteLine("점화 플러그 확인");
        Console.WriteLine("연료 공급");
    }
}
class Battery()
{
	public void Disconnected()
	{
        Console.WriteLine("배터리 분리");
    }
}
// 소설, 게임를 예를 들자면
// 설정집(설계도- 속성과 기능을 설명) > 게임소설(실제로 행동하게 한다- 객체간의 상호관계)
// 클래스는 설계도
// 객체는 클래스를 바탕으로 한 실존하는 무언가
#endregion


//string player "플레이어"; > 이걸 다 일일이 만들어 속성도 다 다른데 > 묶자
class Knight
{
	public int hp;
	public int attack;

	public void Move() {
	
	}

    public void Attack(Monster monster)
    {
		monster.hp = this.attack;
    }
}
// 이것이 설정집이고 > 그것을 소환하는 것 > 소설이 완성
// 객체를 만드는 법
//Knight knight = 'new' Knight();
//클래스를 만들고 객체를 만들기 위해서 new가 필요
// 보통은 기능을 쓰기 위해 new를 반복하지 않고 값을 어떤 변수로 담아둔다

// 구조체 > 변수의 묶음 (이외 용도로 사용금지! > 함수를 넣을 수 있지만 절대로 하지마라!)
// struct (구조체이름)
struct Player// 이 구조체만 있으면 모든 변수를 한꺼번에 묶을 수 있다
{            // 함수는 넣지 마라....
	public int hp;
	public int attack;
}

//Player player;
//player.hp = 100;
//player.attack = 10;

// 콘솔창에 아래와 같은 화면이 출력되도록 만들어 주세요
// 번호 입력시 무조건 1, 2, 3, 4 중 하나만 입력 한다고 가정합니다.

//===================================
//         [ 직업을 선택하세요 ]        
//===================================
// 1. 전사 (Warrior)
// 2. 마법사 (Mage)
// 3. 도적 (Rogue)
// 4. 마법소녀 (Magical Girl)
//===================================
//번호를 입력하세요: 2
//마법사를 선택하셨습니다.