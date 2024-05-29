# basic-aspnet-2024
IoT 개발자과정 ASP.NET 리포지토리

## 1일차
- 웹 기술 개요
    - World Wide Web 은 인터넷의 부분 집합
    - Front-end : 웹사이트 화면으로 사람들에게 보이는 부분 기술
    - Back-end : 웹사이트 뒤에서 동작하는 서버기술
    - Server-Operateion : HW, OS, SW등 운영(클라우드)

- 업무용 웹 사이트 참조
    - https://www.ecount.com/kr/ECK/ECK004M_CN.aspx

- Front-end(클라이언트)
    - HTML5
    - CSS3
    - Javascript

- Back-end(서버)
    1. Java - Spring, Spring Boot, JSP, EJB ...
    2. Javascript - Node.js, Express ...
    3. Python - Django, Flask, fastAPI ...
    4. C# - ASP.NET
    5. Ruby - Ruby on rails
    6. C - cgi, fasCGI ...
    7. PHP 

- 개발
    - 프론트엔드 전부 + 백엔드 여러개 중 하나 + DB
    - 웹 브라우저에서 개발자도구(F12)

- HTML5
    - XML(eXtensibe Markup Lang)이 웹페이지 구성하기 위한 선행 기술, 너무 복잡해서 간략화 시킨 것
    - Hyper Text Markup Language
    - 기본적으로 확장자 .html 
    - tip! lorem 탭, 긴 샘플 텍스트 생성
    - 기본태그(body에 사용)
    - 요소
        - h1 ~ h6 : 제목(마크다운 #, ##와 동일)
        - p : 일반문장
        - div : 그룹화 구분자, 아주 중요(CSS 연계 디자인)
        - img : 이미지 표현
        - br : 한줄 내리기(엔터)
        - hr : 가로선
        - 특수문자 : & ; 사이에 영문자로 표시(너무 많음)
        - strong 또는 b : 볼드체
        - em : 이탤릭체
        - mark : 형광펜 효과
        - small, sub, sup : 글자 작게, 아래첨자, 윗첨자
        - u, strike : 밑줄, 취소선
        - a : 웹페이지 링크
        - Ul, ol > li : 순서없는 목록, 순번있는 목록
        - table, tr, th, td : 테이블 만드는 태그
        - audio, video : 오디오, 비디오
        - object, embed : 객체 추가

    - HTML + CSS + javascript
        - 내부 스타일, 외부 스타일, 인라인 스타일
        - 내부스크립트, 외부 스크립트, 인라인 스크립트

    - 오류, 디버그
        - F12 개발자 도구로 활용
    
    - 양식태그(body > form안에 사용 필수)
        - form-end : 입력한 내용이 back-end로 보내기위한 관문
        - form 을 반드시 사용
        - input
            - type="text" : 텍스트박스
            - type="password" : 비밀번호 박스
            - type="button" : 일반버튼
            - type="submit" : 제출(!)
            - checkbox : 체크박스
            - radio : 라디오 버튼
            - file : 파일 업로드
            - image : 이미지(img와 유사)
            - reset : 폼내의 입력양식 태그 값 초기화
            - hidden : 숨김값(유용하게 사용!!)
        - select : 콤보 박스
        - fieldset : 그룹 박스
        - textarea : 여러행 텍스트 입력
        - submit 클릭 loopback(값 전달) 발생
        - 값 전달 방법
            - GET : URL뒤 ? 다음에 key=value&key=value ... 데이터 전달
            - POST : 화면 뒤로 숨겨서 데이터 전달 방식

    - 공간구분 태그
        - sapn - 한줄로 공간구성
        - div - 행간으로 블록지정 공간 구성

## 2일차
- HTML5
    - 시맨틱 태그
- CSS3
    - 웹 디자인
- Javascript