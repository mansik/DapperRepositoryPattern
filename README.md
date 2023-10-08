# DapperRepositoryPattern

[Repository Pattern with C# and Dapper ORM | FoxLearn](https://youtu.be/uS9Sy97Su_E?si=Qx4Ytl-OCUR5OSTe)

## 설명:  Dapper + Repository Pattern(테이블 클래스, DB연동 클래스/인터페이스 분리)

## 환경
* Visual Studio: [ ] 2019, [x] 2022
* 프로젝트 생성: [ ] .Net Framework, [x] .Net WinForm(windows form)
* Package 
  * [ ] DevExpress 18.2
* NuGet
  * [x] System.Data.SqlClient
  * [x] Dapper

## 작업
* IGenericRepository<T>를 상속해서 각 Repository 클래스를 구현할 경우 매개변수명칭은 클래스에 맞게 수정해서 사용한다.
* ex) public bool Add(Student entity) => public bool Add(Student student)
