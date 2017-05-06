# Julue-Mable

This project only written by Korean.

---
놀라운 팀 이름!

---
## 진행 상황
Null
---
## 프로그램 작성자들이 지켜주어야 할 규칙
### 1. Commit 전 fetch, merge 하기
-- 안 하면 그 목숨은 보장할 수 없다. <br>
-- 죽을 것이다. <br>
### 2. Pull Request 후 알리기
-- 단톡방에 한 번씩만 언급해줍시다 <br>
-- 양소희 팀원이 fetch 하라고 하면 fetch 해줍시다<br>
### 3. 주석 자주 달기
-- 주석을 달지 않는다면 일어날 일에 대해서는 굳이 언급하진 않겠습니다... <br>
-- 매우 끔찍해질 것이야 <br>
### 4. Issues 이용하기
-- 해결 못 한 버그나 구현하고 싶은 기능 등, 다른 팀원의 협력이 필요한 사항은 화면 상단의 Issues에 들어가서 올립시다.<br>

---
## 간단 Git Bash 사용법
### 1. 지정 폴더 들어가기
-- ls :: 현재 디렉터리의 파일 및 하위 디렉터리를 보여준다<br>
-- cd <하위 디렉터리명> :: 하위 디렉터리로 이동한다<br>
-- cd .. :: 상위 디렉터리로 이동한다<br>

&nbsp;&nbsp;&nbsp;**1-1. git clone**<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;-- github에 올라와 있는 파일을 (현재 디렉터리에) 다운 받는 명령어<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;-- 최초 한 번만 하면 된다.<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;--**사용법 :: git clone https://github.com/Awesome-Team-Name/Julue-Marble.git**<br>
&nbsp;&nbsp;&nbsp;**1-2. git pull**<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;-- 현재 디렉터리의 프로젝트를 github에 올라온 최신 버전으로 업데이트 하는 명령어<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;-- 항상 최신 버전을 유지하기 위해, 다른 팀원이 git push를 했다면 git pull를 해야한다.<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;--**사용법 :: git pull**<br>

### 2. git add
-- 파일을 준비 영역에 추가하는 명령어<br>
-- **사용법 :: git add <파일 또는 폴더명>**<br>
-- ex) git add YSH/ <br>
-- ex) git add test.cpp <br>
### 3. git commit
-- (git add로 추가된) 준비 영역의 파일을 최종 확정하는 명령어<br>
-- **사용법 :: git commit -m "파일에 대한 설명 문구"**<br>
-- ex) git commit -m "커밋 테스트" <br>
### 4. git push
-- (git commit으로 확정된) 파일을 원격 서버에 올리는 명령어<br>
-- 아마 처음엔 로그인 하라고 에러 메시지가 나올텐데, 침착하게 자기 아이디랑 비번을 입력하면 된다.<br>
-- **사용법 :: git push**<br>
### 5. git status
-- 현재 폴더의 상태 확인<br>
-- 수정된 파일 등을 나타냄 <br>
-- **사용법 :: git status** <br>
### 6. 자신의 업로드 이후
#### -- ( add -> commit -> push 이후 할 일)
-- 자신의 업로드 내역을 적용시키기 위해 요청해야함 <br>
-- 자신의 Repository (웹 사이트) -> [Pull requests] -> [New pull request] -> [Create pull request]<br>
### 7. 누군가의 업로드 이후
#### -- ( = 자신이 commit 하기 전 항상 해야 할 명령어)

--  <font size = 4.5> <b>git fetch upstream</b> <br>
-- <b>git merge upstream/master</b><br>
-- <b>git push</b></font>

### * 석 줄 요약
-- 한 번도 clone을 안 했을 경우, clone을 한다.<br>
-- **add -> commit -> push** 순으로 파일 업로드<br>
-- 다른 팀원들이 새로 업로드 했을 경우, **fetch -> merge -> push**를 한다.<br>

---

### 참고 사항
-- [try helloworld](http://tryhelloworld.co.kr/courses/unity%EB%A1%9C-%EB%B0%B0%EC%9A%B0%EB%8A%94-csharp)
-- [Unity Korea](https://unity3d.com/kr/learn)