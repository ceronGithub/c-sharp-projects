# c# projects

all you need to learn about c#

git bash on folder 
> git init 
> git remote add origin url
//> git checkout -b develop (create new branch) / to change branch (git checkout (branch name))

uploading to git website
> goto folder > git bash there
> git remote add origin url
> git checkout -b develop (create new branch) / to change branch (git checkout (branch name))
> git add .
> git status
> git config --global user.email "..."
> git config --global user.name "..."
> git commit -m "name the changes"
> git status
> if error on pushing, try closing the editor, then try pushing again.
> git push -u origin branch name

update:

>open git bash (inside project folder)
>git pull (do this if yourworking with group, this updates your project, to the latest version of the project)
>git add .
>git status
>git commit -m "changes / name the change" 
>git remote add origin (goto github, click the repo of the project, look for this -> "<>code", then click it, under https copy the https)
>git push -u origin (branch name)


getting project from git website
> git clone (goto github, click the repo of the project, look for this -> "<>code", then click it, under https copy the https)
