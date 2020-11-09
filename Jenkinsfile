pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        sh 'dotnet build'
      }
    }

    stage('Test') {
      steps {
        sh 'dotnet test'
      }
    }

    stage('Message') {
      steps {
        sh 'echo "Worked!!"'
      }
    }

  }
}