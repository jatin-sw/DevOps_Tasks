$ExpirationDate = Get-Date
$certs = Get-ChildItem -Path cert:\LocalMachine\TrustedPublisher -Recurse `

foreach($cert in $certs)
{

If($Cert.NotAfter -le $ExpirationDate) {
    $Cert | Remove-Item
              
    }
}


